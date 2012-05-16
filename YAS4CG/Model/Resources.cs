using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    internal class Resource
    {
        public string Name { get; set; }

        public string Desc { get; set; }
    }

    internal class Weapon : Resource
    {
        public Skill RequiredSkill { get; set; }

        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    internal class Gear : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    internal class Augmentation : Resource
    {
        public float EssenceCost { get; set; }

        public int Cost { get; set; }

        public Dictionary<Attribute, int> Stats { get; set; }

        public Dictionary<string, Quality> Qualities { get; set; }
    }

    internal class Vehicle : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    internal class Drone : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    internal class Spell : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    internal class Spirit : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    internal class BondingFocus : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    internal class ComplexForm : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }
    internal class Sprite : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }
}