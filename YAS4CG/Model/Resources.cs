using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    internal class Resource
    {
        public string Name { get; set; }

        public int Count { get; set; }

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

    public sealed class DeviceRating
    {
        public static readonly DeviceRating DeviceRating1 = new DeviceRating(1, 250, 4, "Dumb. General appliances, bodyware.");
        public static readonly DeviceRating DeviceRating2 = new DeviceRating(2, 750, 4, "Simple. Public terminals, entertainment systems.");
        public static readonly DeviceRating DeviceRating3 = new DeviceRating(3, 1250, 8, "Average. Standard personal electronics, headware, vehicles, drones, home/business terminals.");
        public static readonly DeviceRating DeviceRating4 = new DeviceRating(4, 2000, 8, "Complex. Security vehicles, alphaware, research terminals, security devices.");
        public static readonly DeviceRating DeviceRating5 = new DeviceRating(5, 4000, 12, "Smart. High-end devices, betaware, security terminals, military vehicles.");
        public static readonly DeviceRating DeviceRating6 = new DeviceRating(6, 8000, 16, "Cutting Edge. Deltaware, credsticks.");

        public DeviceRating(int rating, int cost, int availability, string desc)
        {
            Rating = rating;
            UpgradeCost = cost;
            Availability = availability;
            Desc = desc;
        }

        public int Rating { get; set; }

        public int UpgradeCost { get; set; }

        public int Availability { get; set; }

        public string Desc { get; set; }
    }

    public sealed class SignalRating
    {
        public static readonly SignalRating SignalRating1 = new SignalRating(1, 10, 4, "40m. RFID tags, handheld electronics.");
        public static readonly SignalRating SignalRating2 = new SignalRating(2, 50, 4, "100m. Headware transceivers, micro-drone sensors.");
        public static readonly SignalRating SignalRating3 = new SignalRating(3, 150, 8, "400m. Average commlinks, residential/small business wi-fi routers, vehicular autonav sensors.");
        public static readonly SignalRating SignalRating4 = new SignalRating(4, 500, 8, "1km. Crawler-drone sensors.");
        public static readonly SignalRating SignalRating5 = new SignalRating(5, 1000, 12, "4km. Cyberlimb transceivers, heavy drone surveillance sensors.");
        public static readonly SignalRating SignalRating6 = new SignalRating(6, 3000, 16, "10km. Cell-phone towers, public access wi-fi routers.");

        public SignalRating(int rating, int cost, int availability, string desc)
        {
            Rating = rating;
            UpgradeCost = cost;
            Availability = availability;
            Desc = desc;
        }

        public int Rating { get; set; }

        public int UpgradeCost { get; set; }

        public int Availability { get; set; }

        public string Desc { get; set; }
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
        public string Type { get; set; }

        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get { return 3; } }
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