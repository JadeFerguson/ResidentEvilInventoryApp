using System;
using System.Collections.Generic;

namespace ResidentEvilInventoryApp
{
    public partial class UserInventory
    {
        public byte UserId { get; set; }
        public string Ammo { get; set; } = null;
        public string FirstAid { get; set; } = null;
        public string Fuel { get; set; } = null;
        public string Herbs { get; set; } = null;
        public string Misc { get; set; } = null;
        public string Supplements { get; set; } = null;
        public string Weapons { get; set; } = null;
    }
}
