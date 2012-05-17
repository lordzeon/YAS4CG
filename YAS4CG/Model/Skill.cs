using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    internal class Skill
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public SkillType Type { get; set; }

        public Attribute ParentAttribute { get; set; }

        public string Desc { get; set; }
    }

    internal class SkillGroup
    {
        public string Name { get; set; }
         
        public int Value { get; set; }

        //Key -> Skill.Name
        public Dictionary<string, Skill> Skills { get; set; }
    }

    public enum SkillType
    {
        Active,
        Knowledge,
        Specialization
    }
}