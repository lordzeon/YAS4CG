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

    public sealed class AugmentationGrade
    {   //Make sure to only offer standard and alpha during character creation, and give options for beta and delta in the settings.
        public static readonly AugmentationGrade StandardGrade = new AugmentationGrade(1, 1, "Basic ware is cheap, but not very Essence-friendly. Most people don’t care what brand of cyberware they get, as long as it works—datajacks, cybereyes and other common mods are low enough in cost and Essence loss that neither matters to the general public.");
        public static readonly AugmentationGrade AlphaGrade = new AugmentationGrade(2, .8, "Alphaware appeals more to the guys and gals who count on cyberware to survive. Alphaware costs more, but is easier on the body (and Essence).");
        public static readonly AugmentationGrade BetaGrade = new AugmentationGrade(4, .7, "Betaware is harder to find, but still available to the general public. Betaware is costs much more, but is even easier on the body (and Essence).");
        public static readonly AugmentationGrade DeltaGrade = new AugmentationGrade(10, .5, "Deltaware is heavy megacorp, or miltech hardware. Very hard to find and very expensive, but deltaware is much easier on the body (and Essence).");

        public AugmentationGrade(int cost, double essenceCost, string desc)
        {
            CostMultiplier = cost;
            EssenceCostMultiplier = essenceCost;
            Desc = desc;
        }

        public int CostMultiplier { get; set; }

        public double EssenceCostMultiplier { get; set; }

        public string Desc { get; set; }
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
        public Dictionary<string, Attribute> Attributes { get; set; }

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
        public Dictionary<string, Attribute> Attributes { get; set; }

        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }
}