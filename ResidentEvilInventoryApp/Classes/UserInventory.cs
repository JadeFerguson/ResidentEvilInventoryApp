using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ResidentEvilInventoryApp.Classes
{
    public partial class UserInventory
    {
        // ? needed after string so its optional and does not add null to every column

        /// <summary>
        /// This is our primary key
        /// </summary>
        public byte UserId { get; set; }
        
        /// <summary>
        /// ammo for weapons
        /// </summary>
        public string? Ammo { get; set; } = null;
        
        /// <summary>
        /// First aid box being a larger heal and spray being a small heal for health
        /// </summary>
        public string? FirstAid { get; set; } = null;
        
        /// <summary>
        /// Fuel being gas for the flamethrower and molotov
        /// </summary>
        public string? Fuel { get; set; } = null;
        
        /// <summary>
        /// green herbs heal you
        /// blue herbs remove poison from your body
        /// red herbs are combined with other herbs to make them more powerful 
        /// yellow herbs also heal your health but heal you for less
        /// </summary>
        public string? Herbs { get; set; } = null;

        /// <summary>
        /// Justin Lim
        /// </summary>
        public string? Misc { get; set; } = null;

        /// <summary>
        /// Combined with Chem fluid to make other things
        /// </summary>
        public string? Supplements { get; set; } = null;

        /// <summary>
        /// Weapons include
        /// Flamethrower
        /// Pistol
        /// Shotgun
        /// Magnum
        /// Hunting Rifle
        /// RPG
        /// </summary>
        public string? Weapons { get; set; } = null;

        // Needed to over ride the null needed and to list the items in a list book to delete
        public override string ToString()
        {
            return Ammo + FirstAid + Fuel + Herbs + Misc + Supplements + Weapons;
        }
    }
}
