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
    public partial class frmHerbs : Form
    {
        public frmHerbs()
        {
            InitializeComponent();
        }

        private void PopulateHerbsListBox()
        {
            lstHerbs.Items.Add("Green Herb");
            lstHerbs.Items.Add("Blue Herb");
            lstHerbs.Items.Add("Red Herb");
            lstHerbs.Items.Add("Yellow Herb");

        }

        private void PopulateDeleteHerbListBox()
        {
            InventoryContext dbContext = new();
            List<UserInventory> userInventories = (from item in dbContext.UserInventories
                                                   where item.Herbs != null
                                                   select item).ToList();
            foreach (UserInventory item in userInventories)
            {
                lstRemoveHerb.Items.Add(item.Herbs);
            }
        }

        private void frmHerbs_Load(object sender, EventArgs e)
        {
            PopulateHerbsListBox();
            PopulateDeleteHerbListBox();
        }

        public void btnAddHerbs_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Resident_Evil_4___Sound_Effect);
            player.Play();

            InventoryContext dbContext = new();

            string chosenItem = (string)lstHerbs.SelectedItem;
            var herb = new UserInventory { Herbs = chosenItem };
            dbContext.UserInventories.Add(herb);
            lstRemoveHerb.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteHerbListBox();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Resident_Evil_4___Sound_Effect);
            player.Play();

            InventoryContext dbContext = new();

            string chosenItem = (string)lstRemoveHerb.SelectedItem;
            UserInventory herb = dbContext.UserInventories.FirstOrDefault(herb => herb.Herbs == chosenItem);
            dbContext.UserInventories.Remove(herb);
            lstRemoveHerb.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteHerbListBox();
        }
    }
}
