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

        private void PopulateDeleteWeaponsListBox()
        {
            InventoryContext dbContext = new();
            List<UserInventory> userInventories = (from item in dbContext.UserInventories
                                                   where item.Weapons != null
                                                   select item).ToList();
            foreach (UserInventory item in userInventories)
            {
                lstRemoveWeapons.Items.Add(item.Weapons);
            }
        }

        private void frmWeapons_Load(object sender, EventArgs e)
        {
            PopulateWeaponsListBox();
            PopulateDeleteWeaponsListBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Resident_Evil_4___Sound_Effect);
            player.Play();

            InventoryContext dbContext = new();

            string chosenItem = (string)lstWeapons.SelectedItem;
            var weapon = new UserInventory { Weapons = chosenItem };
            dbContext.UserInventories.Add(weapon);
            lstRemoveWeapons.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteWeaponsListBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Resident_Evil_4___Sound_Effect);
            player.Play();

            InventoryContext dbContext = new();

            string chosenItem = (string)lstRemoveWeapons.SelectedItem;
            UserInventory weapon = dbContext.UserInventories.FirstOrDefault(weapon => weapon.Weapons == chosenItem);
            dbContext.UserInventories.Remove(weapon);
            lstRemoveWeapons.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteWeaponsListBox();
        }
    }
}
