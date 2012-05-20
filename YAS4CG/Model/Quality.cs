using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    public class Quality
    {
        public string Name { get; set; }

        public int BPCost { get; set; }

        public string Desc { get; set; }

        public Quality(string name, int cost, string desc)
        {
            Name = name;
            BPCost = cost;
            Desc = desc;
        }
    }
}