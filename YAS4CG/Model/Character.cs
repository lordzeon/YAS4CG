using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    internal class Character
    {
        public string Name { get; set; }

        public int BPTotal { get; set; }

        public int Initiative { get; set; }

        public MetaType MetaType { get; set; }

        //Key -> Attribute.Name
        public Dictionary<string, Attribute> Attributes { get; set; }

        //Key -> Skill.Name
        public Dictionary<string, Skill> Skills { get; set; }

        //Key -> Quality.Name
        public Dictionary<string, Quality> Qualities { get; set; }

        //Key -> Resource.Name
        public Dictionary<string, Weapon> Weapons { get; set; }

        //Key -> Gear.Name
        public Dictionary<string, Gear> Gear { get; set; }

        public string Desc { get; set; }
    }
}