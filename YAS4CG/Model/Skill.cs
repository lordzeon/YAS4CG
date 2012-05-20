using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    public class Skill
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public SkillType Type { get; set; }

        public string ParentAttribute { get; set; }

        public Dictionary<string, Skill> Specializations { get; set; }

        public string Desc { get; set; }

        public Skill(string name, SkillType type, string parentAtt, string desc)
        {
            Name = name;
            Value = 0;
            Type = type;
            ParentAttribute = parentAtt;
            Specializations = new Dictionary<string, Skill>();
            Desc = desc;
        }
    }

    public class SkillGroup
    {
        public string Name { get; set; }
         
        public int Value { get; set; }

        //Key -> Skill.Name
        public Dictionary<string, Skill> Skills { get; set; }

        public SkillGroup(string name)
        {
            Name = name;
            Value = 0;
            Skills = new Dictionary<string, Skill>();
        }
    }

    public enum SkillType
    {
        Active,
        Knowledge,
        Specialization
    }
}