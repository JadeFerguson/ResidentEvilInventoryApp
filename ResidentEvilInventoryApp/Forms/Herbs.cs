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

        private void btnAddHerbs_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstHerbs.SelectedItem;
            var herb = new UserInventory { Herbs = chosenItem };
            dbContext.UserInventories.Add(herb);
            dbContext.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstRemoveHerb.SelectedItem;
            UserInventory herb = dbContext.UserInventories.FirstOrDefault(herb => herb.Herbs == chosenItem);
            dbContext.UserInventories.Remove(herb);
            dbContext.SaveChanges();
        }
    }
}
