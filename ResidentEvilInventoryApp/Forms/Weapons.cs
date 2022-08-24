using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResidentEvilInventoryApp.Classes;
using ResidentEvilInventoryApp.Data;

namespace ResidentEvilInventoryApp
{
    public partial class frmWeapons : Form
    {
        public frmWeapons()
        {
            InitializeComponent();
        }

        private void PopulateWeaponsListBox()
        {
            lstWeapons.Items.Add("Flamethrower");
            lstWeapons.Items.Add("Pistol");
            lstWeapons.Items.Add("Shotgun");
            lstWeapons.Items.Add("Magnum");
            lstWeapons.Items.Add("Hunting Rifle");
            lstWeapons.Items.Add("RPG");
        }

        private void frmWeapons_Load(object sender, EventArgs e)
        {
            PopulateWeaponsListBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstWeapons.SelectedItem;
            var weapon = new UserInventory { Weapons = chosenItem };
            dbContext.UserInventories.Add(weapon);
            dbContext.SaveChanges();
        }
    }
}
