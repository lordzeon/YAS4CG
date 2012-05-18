using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{
    class Rulebook
    {
        public string Name { get; set; }

        //Key -> Attribute.Name
        public Dictionary<string, Attribute> Attributes { get; set; }

        //Key -> Quality.Name
        public Dictionary<string, Quality> Qualities { get; set; }

        //Key -> Skill.Name
        public Dictionary<string, Skill> Skills { get; set; }

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
    }
}
