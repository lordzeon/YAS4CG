using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    public class Resource
    {
        public string Name { get; set; }

        public int Count { get; set; }

        public string Desc { get; set; }
    }

    public class Weapon : Resource
    {
        public string Type { get; set; }

        public string Category { get; set; }

        public string Stats { get; set; }

        public int Cost { get; set; }

        public Weapon(string name, string type, string category, int cost, string stats, string desc)
        {
            Name = name;
            Type = type;
            Category = category;
            Stats = stats;
            Cost = cost;
            Desc = desc;
        }
    }

    public class WeaponAccessory : Resource
    {
        public string Stats { get; set; }

        public int Cost { get; set; }

        public WeaponAccessory(string name, string stats, int cost, string desc)
        {
            Name = name;
            Stats = stats;
            Cost = cost;
            Desc = desc;
        }
    }

    public class Ammo : Resource
    {
        public string Stats { get; set; }

        public int Cost { get; set; }

        public Ammo(string name, string stats, int cost, string desc)
        {
            Name = name;
            Stats = stats;
            Cost = cost;
            Desc = desc;        
        }
    }

    public class Grenade : Resource
    {
        public string Stats { get; set; }

        public int Cost { get; set; }

        public Grenade(string name, string stats, int cost, string desc)
        {
            Name = name;
            Stats = stats;
            Cost = cost;
            Desc = desc;        
        }
    }

    public class Explosive : Resource
    {
        public string Stats { get; set; }

        public int Cost { get; set; }

        public Explosive(string name, string stats, int cost, string desc)
        {
            Name = name;
            Stats = stats;
            Cost = cost;
            Desc = desc;        
        }
    }

    public class RocketMissile : Resource
    {
        public string Type { get; set; }

        public string Stats { get; set; }

        public int Cost { get; set; }

        public RocketMissile(string name, string type, string stats, int cost, string desc)
        {
            Name = name;
            Type = type;
            Stats = stats;
            Cost = cost;
            Desc = desc;        
        }
    }

    public class Clothing : Resource
    {
        public string Stats { get; set; }

        public int Cost { get; set; }

        public Clothing(string name, string stats, int cost, string desc)
        {
            Name = name;
            Stats = stats;
            Cost = cost;
            Desc = desc;        
        }
    }

    public class ArmorModification : Resource
    {
        public string Stats { get; set; }

        public int CostMultiplier { get; set; }

        public int Cost { get; set; }

        public ArmorModification(string name, string stats, int costmultiplier, string desc)
        {
            Name = name;
            Stats = stats;
            Cost = costmultiplier;
            Desc = desc;        
        }
    }

    public class Commlink : Resource
    {
        public int Response { get; set; }

        public SignalRating Signal { get; set; }

        public int Cost { get; set; }

        public Commlink(string name, SignalRating signal, int costmultiplier, string desc)
        {
            Name = name;
            Signal = signal;
            Cost = costmultiplier;
            Desc = desc;        
        }
    }

    public class ElectronicAccessory : Resource
    {
        public DeviceRating DeviceRating { get; set; }

        public string Stats { get; set; }

        public int Cost { get; set; }

        public ElectronicAccessory(string name, string stats, DeviceRating devicerating, int cost, string desc)
        {
            Name = name;
            Stats = stats;
            DeviceRating = devicerating;
            Cost = cost;
            Desc = desc;        
        }
    }

    public class CommAccessory : Resource
    {
        public DeviceRating DeviceRating { get; set; }

        public string Stats { get; set; }

        public int CostMultiplier { get; set; }

        public CommAccessory(string name, string stats, DeviceRating devicerating, int costMultiplier, string desc)
        {
            Name = name;
            Stats = stats;
            DeviceRating = devicerating;
            CostMultiplier = costMultiplier;
            Desc = desc;        
        }
    }

    public class OperatingSystem
    {
        public string Name { get; set; }

        public int Firewall { get; set; }

        public int System { get; set; }

        public int Cost { get; set; }

        public OperatingSystem(string name, int firewall, int system, int cost)
        {
            Name = name;
            Firewall = firewall;
            System = system;
            Cost = cost;
        }
    }

    public class ProgramSuite : Resource
    {
        public string Stats { get; set; }

        public int Cost { get; set; }

        //public ProgramSuite
    }

    public class MatrixProgramCategory
    {
        public string Name { get; set; }

        public int Rating3CostMultiplier { get; set; }

        public int Rating6CostMultiplier { get; set; }

        public string Desc { get; set; }
    }

    public class MatrixProgram : Resource
    {
        public string Stats { get; set; }

        public int Rating { get; set; }

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

    public class Augmentation : Resource
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

    public class Vehicle : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    public class Drone : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    public class Spell : Resource
    {
        public string Type { get; set; }

        public string Stats { get; set; }

        public int Cost { get { return 3; } }

        public Spell(string name, string type, string stats, string desc)
        {
            Name = name;
            Type = type;
            Stats = stats;
            Desc = desc;
        }
    }

    public class Spirit : Resource
    {
        public Dictionary<string, Attribute> Attributes { get; set; }

        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    public class BondingFocus : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    public class ComplexForm : Resource
    {
        public Dictionary<string, string> Stats { get; set; }

        public int Cost { get; set; }
    }

    public class Sprite : Resource
    {
        public string Stats { get; set; }

        public string Skills { get; set; }

        public string ComplexForms { get; set; }

        public string Powers { get; set; }

        public string OptionalCFs { get; set; }

        public int Cost { get; set; }
    }

    public sealed class LifeStyle
    {
        public static readonly LifeStyle Streets = new LifeStyle(0, "The character lives on the streets—or in the sewers, steam tunnels, condemned buildings, or whatever temporary flop she can get. Food is wherever the character  finnds it, bathing is a thing of the past, and the character’s only security is what she creates for herself.  This lifestyle is the bottom of the ladder, inhabited by down-and-outers of all stripes.");
        public static readonly LifeStyle Squatter = new LifeStyle(500, "Life stinks for the squatter, and most of the time so does the character. She eats low-grade nutrisoy and yeast, adding flavors with an eyedropper. Her home is a squatted building, perhaps fixed up a bit, possibly even converted into barracks or divided into closet-sized rooms and shared with other squatters. Or maybe she just rents a coffin-sized sleep tank by the night. The only thing worse than the Squatter lifestyle is living on the streets.");
        public static readonly LifeStyle Low = new LifeStyle(2000, "With this lifestyle, the character has an apartment, and nobody is likely to bother her much if she keeps the door bolted. She can count on regular meals; the nutrisoy may not taste great, but at least it’s hot. Power and water are available during assigned rationing periods. Security depends on how regular the payments to the local street gang are. Factory workers, petty crooks, and other folks stuck in a rut, just starting out, or down on their luck tend to have Low lifestyles.");
        public static readonly LifeStyle Middle = new LifeStyle(5000, "The Middle lifestyle offers a nice house or condo with lots of comforts. Characters with this lifestyle sometimes eat nutrisoy as well as higherpriced natural food, but at least the autocook has a full suite of flavor faucets. This is the lifestyle of ordinary successful wage-earners or criminals.");
        public static readonly LifeStyle High = new LifeStyle(10000, "A High lifestyle offers a roomy house or condo, good food, and the technology that makes life easy. The character may not have the same perks as the really big boys, but neither does she have as many people gunning for her. Her home is in a secure zone or protected by good, solid bribes to the local police contractor and gang boss. She has a housekeeping service or enough tech to take care of most chores. This is the life for the well-to-do on either side of the law: mid-level managers, senior Mob bosses, and the like.");
        public static readonly LifeStyle Luxury = new LifeStyle(100000, "This lifestyle o ers the best of everything: ritzy digs, lots of high-tech toys, the best food and drink, you name it. The character has a household staff, maid service, or sophisticated drones to do the chores. She gets by in her massive mansion, snazzy condo, or the penthouse suite in a top hotel. Home security is top-of-the-line, with well-trained guards, astral security, and quick response times. Her home entertainment system is better than that in public theaters and accessible from anywhere in the home. She’s on the VIP list at several exclusive restaurants and clubs, both real and virtual. This is the life for the high-stakes winners in the world of Shadowrun: high-level executives, government big shots, Yakuza bigwigs, and the few shadowrunners who pull o the big scores (and live to spend their pay).");
        
        public LifeStyle(int cost, string desc)
        {
            Cost = cost;
            Desc = desc;
        }

        public int Cost { get; set; }

        public string Desc { get; set; }
    }


}