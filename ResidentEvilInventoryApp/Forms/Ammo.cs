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
                lstRemoveAmmo.Items.Add(item.Ammo);
            }
        }

        private void frmAmmo_Load(object sender, EventArgs e)
        {
            PopulateAmmoListBox();
            PopulateDeleteAmmoListBox();
        }

        private void btnAddAmmo_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Resident_Evil_4___Sound_Effect);
            player.Play();

            InventoryContext dbContext = new();

            string chosenItem = (string)lstAmmo.SelectedItem;
            var ammo = new UserInventory { Ammo = chosenItem };
            dbContext.UserInventories.Add(ammo);
            lstRemoveAmmo.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteAmmoListBox();
        }

        private void btnDeleteAmmo_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Resident_Evil_4___Sound_Effect);
            player.Play();

            InventoryContext dbContext = new();

            string chosenItem = (string)lstRemoveAmmo.SelectedItem;
            UserInventory ammo = dbContext.UserInventories.FirstOrDefault(ammo => ammo.Ammo == chosenItem);
            //var ammo = new UserInventory { Ammo = chosenItem };
            dbContext.UserInventories.Remove(ammo);
            lstRemoveAmmo.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteAmmoListBox();
        }

        private void lstRemoveAmmo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
