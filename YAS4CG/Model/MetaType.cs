using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    public class MetaType : ObservableObject
    {
        public string Name { get; set; }

        public int BPCost { get; set; }

        //Key -> Attribute.Name
        public Dictionary<string, Attribute> Attributes { get; set; }

        //Key -> Attribute.Name
        public Dictionary<string, SpecialAttribute> SpecialAttributes { get; set; }

        public List<string> SpecialAbilities { get; set; }

        public string Desc { get; set; }

        public MetaType(string name, int bpCost, string desc)
        {
            Name = name;
            BPCost = bpCost;
            Desc = desc;
            Attributes = new Dictionary<string, Attribute>();
            SpecialAttributes = new Dictionary<string, SpecialAttribute>();
            SpecialAbilities = new List<string>();
        }
    }
}