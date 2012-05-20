using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    public class Rulebook
    {
        public string Name { get; set; }

        //Key -> Metatype.name
        public Dictionary<string, MetaType> MetaTypes { get; set; }

        //Key -> Quality.Name
        public Dictionary<string, Quality> Qualities { get; set; }

        //Key -> Quality.Name
        public Dictionary<string, Quality> NegativeQualities { get; set; }

        //Key -> Skill.Name
        public Dictionary<string, SkillGroup> SkillGroups { get; set; }

        //Key -> Weapon.Name
        public Dictionary<string, Weapon> Weapons { get; set; }

        //Key -> Gear.Name
        public Dictionary<string, Clothing> Gear { get; set; }

        //Key -> Augmentation.Name
        public Dictionary<string, Augmentation> Augmentations { get; set; }

        //Key -> Vehicle.Name
        public Dictionary<string, Vehicle> Vehicles { get; set; }

        //Key -> Drone.Name
        public Dictionary<string, Drone> Drones { get; set; }

        //Key -> Spell.Name
        public Dictionary<string, Spell> Spells { get; set; }

        //Key -> Spirit.Name
        public Dictionary<string, Spirit> Spirits { get; set; }

        //Key -> BondingFocus.Name
        public Dictionary<string, BondingFocus> BondingFoci { get; set; }

        //Key -> ComplexForm.Name
        public Dictionary<string, ComplexForm> ComplexForms { get; set; }

        //Key -> Sprite.Name
        public Dictionary<string, Sprite> Sprites { get; set; }

        public Rulebook(string name)
        {
            Name = name;
            MetaTypes = new Dictionary<string, MetaType>();
            Qualities = new Dictionary<string, Quality>();
            NegativeQualities = new Dictionary<string, Quality>();
            SkillGroups = new Dictionary<string, SkillGroup>();
            Spells = new Dictionary<string, Spell>();

        }
    }
}
