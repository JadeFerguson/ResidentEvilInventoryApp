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

        private void frmHerbs_Load(object sender, EventArgs e)
        {
            PopulateHerbsListBox();
        }

        private void btnAddHerbs_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstHerbs.SelectedItem;
            var herb = new UserInventory { Herbs = chosenItem };
            dbContext.UserInventories.Add(herb);
            dbContext.SaveChanges();
        }
    }
}
