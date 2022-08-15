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

        private void frmAmmo_Load(object sender, EventArgs e)
        {
            PopulateAmmoListBox();
        }

        private void btnAddAmmo_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstAmmo.SelectedItem;
            var ammo = new UserInventory { Ammo = chosenItem };
            dbContext.UserInventories.Add(ammo);
            dbContext.SaveChanges();
        }
    }
}
