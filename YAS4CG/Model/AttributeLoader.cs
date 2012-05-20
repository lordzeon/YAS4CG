using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace YAS4CG.Model
{
    public static class AttributeLoader
    {
        static Dictionary<string, Attribute> Attributes;
        static Dictionary<string, SpecialAttribute> SpecialAttributes;

        public static void LoadAttributes(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = false;
            doc.Load(filename);

            XmlNodeList AttributeList = doc.GetElementsByTagName("Attribute");
            XmlNodeList SpecialAttributeList = doc.GetElementsByTagName("SpecialAttribute");

            Attributes = GetAttributes(AttributeList);
            SpecialAttributes = GetSpecialAttributes(SpecialAttributeList);

        }

        private static Dictionary<string, Attribute> GetAttributes(XmlNodeList AttributeList)
        {
            Dictionary<string, Attribute> attributes = new Dictionary<string, Attribute>();
            foreach (XmlNode node in AttributeList)
            {
                string name = node.Attributes["name"].InnerText;
                XmlNode descNode = node.FindChildByName("Desc");
                string desc = descNode.InnerText.Trim();
                attributes.Add(name, new Attribute(name, desc));
            }
            return attributes;
        }

        private static Dictionary<string, SpecialAttribute> GetSpecialAttributes(XmlNodeList AttributeList)
        {
            Dictionary<string, SpecialAttribute> attributes = new Dictionary<string, SpecialAttribute>();
            foreach (XmlNode node in AttributeList)
            {
                string name = node.Attributes["name"].InnerText;
                XmlNode descNode = node.FindChildByName("Desc");
                string desc = descNode.InnerText.Trim();
                attributes.Add(name, new SpecialAttribute(name, desc));
            }
            return attributes;
        }
    }
}
