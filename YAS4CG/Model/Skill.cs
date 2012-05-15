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

        //Key -> Skill.Name
        public Dictionary<string, Skill> Skills { get; set; }

        public Attribute ParentAttribute { get; set; }

        public string Desc { get; set; }
    }

    public enum SkillType
    {
        SkillGroup,
        Active,
        Knowledge,
        Specialization
    }
}