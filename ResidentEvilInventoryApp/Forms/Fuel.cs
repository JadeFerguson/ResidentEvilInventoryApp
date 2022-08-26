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
    public partial class frmFuel : Form
    {
        public frmFuel()
        {
            InitializeComponent();
        }

        private void PopulateFuelListBox()
        {
            lstFuel.Items.Add("Fuel");
            lstFuel.Items.Add("Molitovs");
        }

        private void PopulateDeleteFuelListBox()
        {
            InventoryContext dbContext = new();
            List<UserInventory> userInventories = (from item in dbContext.UserInventories
                                                   where item.Fuel != null
                                                   select item).ToList();
            foreach (UserInventory item in userInventories)
            {
                lstRemoveFuel.Items.Add(item.Fuel);
            }
        }

        private void lstFuel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFuel_Load(object sender, EventArgs e)
        {
            PopulateFuelListBox();
            PopulateDeleteFuelListBox();
        }

        private void btnAddFuel_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Resident_Evil_4___Sound_Effect);
            player.Play();

            InventoryContext dbContext = new();
            
            string chosenItem = (string)lstFuel.SelectedItem;
            var fuel = new UserInventory { Fuel = chosenItem };
            dbContext.UserInventories.Add(fuel);
            lstRemoveFuel.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteFuelListBox();

            // for self to check how many things 
            /*int count = (from inventory in dbContext.UserInventories
                                select inventory).Count();
            MessageBox.Show(count.ToString());*/

        }

        private void btnDeleteFuel_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Resident_Evil_4___Sound_Effect);
            player.Play();

            InventoryContext dbContext = new();

            string chosenItem = (string)lstRemoveFuel.SelectedItem;
            UserInventory fuel = dbContext.UserInventories.FirstOrDefault(fuel => fuel.Fuel == chosenItem);
            dbContext.UserInventories.Remove(fuel);
            lstRemoveFuel.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteFuelListBox();
        }
    }
}
