using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    internal class MetaType
    {
        public string Name { get; set; }

        public int BPCost { get; set; }

        //Key -> Attribute.Name
        public Dictionary<string, Attribute> Attributes { get; set; }

        public List<string> SpecialAbilities { get; set; }

        public string Desc { get; set; }

        public MetaType(string name, int bpCost, string desc)
        {
            Name = name;
            BPCost = bpCost;
            Desc = desc;
            Attributes = new Dictionary<string, Attribute>();
            SpecialAbilities = new List<string>();
        }
    }
}