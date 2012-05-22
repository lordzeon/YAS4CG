using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    public class Attribute : ObservableObject
    {
        public string Name { get; set; }

        public int Start { get; set; }

        public int NatMax { get; set; }

        public int AugMax { get; set; }

        public int Value { get; set; }

        public string Desc { get; set; }

        public Attribute(string name, string desc)
        {
            Name = name;
            Desc = desc;
        }

        public Attribute(string name, int start, int natmax, int augmax)
        {
            Name = name;
            Start = start;
            NatMax = natmax;
            AugMax = augmax;
            Value = start;
        }
    }

    public class SpecialAttribute
    {
        public string Name { get; set; }

        public int Start { get; set; }

        public int NatMax { get; set; }

        public int Value { get; set; }

        public string Desc { get; set; }

        public SpecialAttribute(string name, string desc)
        {
            Name = name;
            Desc = desc;
        }

        public SpecialAttribute(string name, int start)
        {
            Name = name;
            Start = start;
            Value = start;
        }
    }
}