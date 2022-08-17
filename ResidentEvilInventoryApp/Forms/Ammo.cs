using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResidentEvilInventoryApp
{
    public partial class frmAmmo : Form
    {
        public frmAmmo()
        {
            InitializeComponent();
        }

        private void PopulateAmmoListBox()
        {
            lstAmmo.Items.Add("Bullets");
        }

        private void PopulateDeleteAmmoListBox()
        {
            InventoryContext dbContext = new();
            List<UserInventory> userInventories = (from item in dbContext.UserInventories
                                                   where item.Ammo != null
                                                   select item).ToList();
            foreach (UserInventory item in userInventories)
            {
                lstRemoveAmmo.Items.Add(item);
            }
        }

        private void frmAmmo_Load(object sender, EventArgs e)
        {
            PopulateAmmoListBox();
            PopulateDeleteAmmoListBox();
        }

        private void btnAddAmmo_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstAmmo.SelectedItem;
            var ammo = new UserInventory { Ammo = chosenItem };
            dbContext.UserInventories.Add(ammo);
            dbContext.SaveChanges();
        }

        private void btnDeleteAmmo_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstRemoveAmmo.SelectedItem;
            var ammo = new UserInventory { Ammo = chosenItem };
            dbContext.UserInventories.Remove(ammo);
            dbContext.SaveChanges();
        }

        private void lstRemoveAmmo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
