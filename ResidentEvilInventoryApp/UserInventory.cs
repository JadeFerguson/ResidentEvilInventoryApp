using System;
using System.Collections.Generic;

namespace ResidentEvilInventoryApp
{
    public partial class UserInventory
    {
        // ? needed after string so its optional and does not add null to every column
        public byte UserId { get; set; }
        public string? Ammo { get; set; } = null;
        public string? FirstAid { get; set; } = null;
        public string? Fuel { get; set; } = null;
        public string? Herbs { get; set; } = null;
        public string? Misc { get; set; } = null;
        public string? Supplements { get; set; } = null;
        public string? Weapons { get; set; } = null;

        // Needed to ovveride the null needed and to list the items in a list book to delete
        public override string ToString()
        {
            return Ammo + FirstAid + Fuel + Herbs + Misc + Supplements + Weapons;
        }
    }
}
