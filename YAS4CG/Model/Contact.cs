using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAS4CG.Model
{


    class Contact
    {
        public string Name { get; set; }

        public ConnectionRating Connection { get; set; }

        public ContactLoyalty Loyalty { get; set; }

        public string Desc { get; set; }
        
    }

    public sealed class ConnectionRating
    {
        public static readonly ConnectionRating ConnectionLevel1 = new ConnectionRating(1, "Knows very few people and has practically no social influence. Many are useful only for their Knowledge skills. Examples: squatter, manual laborer, academic graduate assistant.");
        public static readonly ConnectionRating ConnectionLevel2 = new ConnectionRating(2, "Knows some people but doesn’t have a lot of personal pull. Examples: gang member, bartender, mechanic, mob soldier, corner hustler, corporate wageslave.");
        public static readonly ConnectionRating ConnectionLevel3 = new ConnectionRating(3, "Meets people on a regular basis and has some personal pull. Examples: beat cop, private investigator, street doc, corporate secretary, club owner, street-level fixer or fence.");
        public static readonly ConnectionRating ConnectionLevel4 = new ConnectionRating(4, "Knows many people or may be in a leadership position. Examples: gang boss, mob lieutenant, police detective or sergeant, corporate middle manager, low-level Mr. Johnson, fixer or fence with regional ties.");
        public static readonly ConnectionRating ConnectionLevel5 = new ConnectionRating(5, "Knows lots of people over a larger area, or holds a senior leadership position: police captain, corporate division manager, high-level Mr. Johnson, fixer or fence with national ties.");
        public static readonly ConnectionRating ConnectionLevel6 = new ConnectionRating(6, "Well-connected individual who knows people all over the world, or holds a key executive position. Examples: mob boss, corporate executive, Mr. Johnson or fixer or fence with international ties.");

        private ConnectionRating(int value, string desc)
        {
            Value = value;
            Desc = desc;
        }

        public int Value { get; set; }

        public string Desc { get; set; }
    }

    public sealed class ContactLoyalty
    {
        public static readonly ContactLoyalty LoyaltyLevel1 = new ContactLoyalty(1, "Just Biz. The character and contact have a purely mercenary relationship. Interactions are based solely on economics. They may not even like each other, and will not offer any sort of preferential treatment.");
        public static readonly ContactLoyalty LoyaltyLevel2 = new ContactLoyalty(2, "Regular. The relationship is still all business, but contact at least treats the character with a modicum of respect, like regulars or favored clients.");
        public static readonly ContactLoyalty LoyaltyLevel3 = new ContactLoyalty(3, "Acquaintance. A friendly relationship exists between character and contact, though it would be a stretch to call it a friendship. The contact is willing to be inconvenienced in small ways for the character, but will not take a fall for her.");
        public static readonly ContactLoyalty LoyaltyLevel4 = new ContactLoyalty(4, "Buddy. A friendship or solid level of mutual respect exists. The contact would be willing to go out of his way for the character if necessary.");
        public static readonly ContactLoyalty LoyaltyLevel5 = new ContactLoyalty(5, "Got Your Back. The contact and character have an established relationship and level of trust. The contact will back the character even in risky situations.");
        public static readonly ContactLoyalty LoyaltyLevel6 = new ContactLoyalty(6, "Friend For Life. The contact will do whatever he can for the character, even if it means putting his own life on the line.");

        public ContactLoyalty(int value, string desc)
        {
            Value = value;
            Desc = desc;
        }

        public int Value { get; set; }

        public string Desc { get; set; }
    }

}
