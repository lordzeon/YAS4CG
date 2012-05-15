using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    internal class Resource
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Dictionary<ResourceCostType, float> Costs { get; set; }

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

    //TODO: ADD MORE

    internal enum ResourceType
    {
        Weapon,
        Gear,
        Augmentation,
        Vehicle,
        Spell,
        Spirit,
        BondingFoci,
        ComplexForm,
        Sprite
    }

    internal enum ResourceCostType
    {
        BP,
        Nuyen,
        Essence
    }
}