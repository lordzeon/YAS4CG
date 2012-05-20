using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace YAS4CG.Model
{
    public static class RulebookLoader
    {
        public static Rulebook LoadRulebook(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = false;
            doc.Load(filename);
            
            XmlNodeList rulebookName = doc.GetElementsByTagName("Rulebook");
            
            Rulebook rulebook = new Rulebook(rulebookName[0].Attributes["name"].InnerText);
                   
            XmlNodeList QualityList = doc.GetElementsByTagName("Quality");
            XmlNodeList NegativeQualityList = doc.GetElementsByTagName("NegativeQuality");
            XmlNodeList SkillGroupList = doc.GetElementsByTagName("SkillGroup");
            XmlNodeList MetaTypeList = doc.GetElementsByTagName("Metatype");

            rulebook.Qualities = GetQualities(QualityList);
            rulebook.NegativeQualities = GetQualities(NegativeQualityList);

            rulebook.Skills = GetSkills(SkillGroupList);

            rulebook.MetaTypes = GetMetatypes(MetaTypeList);

            return rulebook;
        }

        private static Dictionary<string, Quality> GetQualities(XmlNodeList QualityList)
        {
            Dictionary<string, Quality> qualities = new Dictionary<string,Quality>();
            foreach (XmlNode node in QualityList)
            {
                string name = node.Attributes["name"].InnerText;
                int cost = Convert.ToInt32(node.Attributes["cost"].InnerText);
                XmlNode descNode = node.FindChildByName("Desc");
                string desc = string.Empty;
                if (descNode != null)
                    desc = descNode.InnerText.Trim();
                qualities.Add(name, new Quality(name, cost, desc));
            }
            return qualities;
        }

        private static Dictionary<string, SkillGroup> GetSkills(XmlNodeList SkillGroupList)
        {
            Dictionary<string, SkillGroup> skillgroups = new Dictionary<string,SkillGroup>();
            foreach (XmlNode node in SkillGroupList)
            {
                string name = node.Attributes["name"].InnerText;
                SkillGroup group = new SkillGroup(name);
                skillgroups.Add(name, group);
                foreach (XmlNode skill in node.ChildNodes)
                {
                    string skillName = skill.Attributes["name"].InnerText;
                    XmlNode parentAtt = skill.FindChildByName("ParentAttribute");
                    XmlNode descNode = skill.FindChildByName("Desc");
                    if (parentAtt == null || descNode == null)
                        continue;
                    Skill newSkill = new Skill(skillName, SkillType.Active, parentAtt.InnerText.Trim(), descNode.InnerText.Trim());
                    group.Skills.Add(skillName, newSkill);

                    XmlNode specializations = skill.FindChildByName("Specializations");
                    if (specializations == null)
                        continue;

                    foreach (XmlNode specialization in specializations)
                    {
                        string specName = specialization.Attributes["name"].InnerText;
                        newSkill.Specializations.Add(specName, new Skill(specName, SkillType.Specialization, newSkill.ParentAttribute, string.Empty));
                    }
                }
            }
            return skillgroups;
        }

        private static Dictionary<string, MetaType> GetMetatypes(XmlNodeList MetatypeList)
        {
            Dictionary<string, MetaType> metatypes = new Dictionary<string, MetaType>();
            foreach (XmlNode metaNode in MetatypeList)
            {
                string name = metaNode.Attributes["name"].InnerText;
                int cost = Convert.ToInt32(metaNode.FindChildByName("BPCost").InnerText.Trim());
                string desc = metaNode.FindChildByName("Desc").InnerText.Trim();
                MetaType metatype = new MetaType(name, cost, desc);

                //Add all the attributes. If one is missing data we do not want to add it
                XmlNode attributes = metaNode.FindChildByName("Attributes");                
                if (attributes == null) continue;
                bool wasCompleteAtt = true;
                foreach (XmlNode attribute in attributes.ChildNodes)
                {
                    if (attribute.Name == "MetaAttribute")
                        wasCompleteAtt = AddAttribute(attribute, metatype);
                    else if (attribute.Name == "MetaSpecialAttribute")
                        wasCompleteAtt = AddSpecialAttribute(attribute, metatype);

                    if (!wasCompleteAtt)
                        break;
                }
                if (wasCompleteAtt && !metatypes.ContainsKey(metatype.Name))
                {
                    //Add special abilities
                    XmlNode abilities = metaNode.FindChildByName("SpecialAbilities");
                    if (abilities != null)
                    {
                        foreach (XmlNode ability in abilities.ChildNodes)
                        {
                            metatype.SpecialAbilities.Add(ability.Attributes["name"].InnerText);
                        }                        
                    }
                    metatypes.Add(metatype.Name, metatype);
                }           
            }
            return metatypes;
        }

        private static bool AddAttribute(XmlNode attribute, MetaType metatype)
        {
            string attName = attribute.Attributes["name"].InnerText;
            XmlNode attStart = attribute.FindChildByName("Start");
            XmlNode attNatMax = attribute.FindChildByName("NaturalMax");
            XmlNode attAugMax = attribute.FindChildByName("AugmentedMax");

            if ((attStart == null || attNatMax == null || attAugMax == null || !AttributeLoader.Attributes.ContainsKey(attName)) && !metatype.Attributes.ContainsKey(attName))
                return false;

            metatype.Attributes.Add(attName, new Attribute(attName, Convert.ToInt16(attStart.InnerText.Trim()), Convert.ToInt16(attNatMax.InnerText.Trim()), Convert.ToInt16(attAugMax.InnerText.Trim())));

            return true;
        }

        private static bool AddSpecialAttribute(XmlNode attribute, MetaType metatype)
        {
            string attName = attribute.Attributes["name"].InnerText;
            XmlNode attStart = attribute.FindChildByName("Start");

            if ((attStart == null || !AttributeLoader.SpecialAttributes.ContainsKey(attName)) && !metatype.SpecialAttributes.ContainsKey(attName))
                return false;

            metatype.SpecialAttributes.Add(attName, new SpecialAttribute(attName, Convert.ToInt16(attStart.InnerText.Trim())));

            return true;
        }
    }


    public static class ExtensionMethods
    {
        public static XmlNode FindChildByName(this XmlNode node, string name)
        {
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.Name == name)
                    return child;
            }
            return null;
        }
    }
}
