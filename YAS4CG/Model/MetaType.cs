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

        //Key -> Quality.Name
        public Dictionary<string, Quality> Qualities { get; set; }

        public string Desc { get; set; }
    }
}