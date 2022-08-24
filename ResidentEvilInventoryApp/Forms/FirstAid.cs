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
    public partial class frmFirstAid : Form
    {
        public frmFirstAid()
        {
            InitializeComponent();
        }

        private void PopulateFirstAidListBox()
        {
            lstFirstAid.Items.Add("First Aid Box");
            lstFirstAid.Items.Add("First Aid spray");
        }

        private void PopulateDeleteFirstAidListBox()
        {
            InventoryContext dbContext = new();
            List<UserInventory> userInventories = (from item in dbContext.UserInventories
                                                   where item.FirstAid != null
                                                   select item).ToList();
            foreach (UserInventory item in userInventories)
            {
                lstRemoveFirstAid.Items.Add(item.FirstAid);
            }
        }

        private void btnAddFirstAid_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstFirstAid.SelectedItem;
            var firstAid = new UserInventory { FirstAid = chosenItem };
            dbContext.UserInventories.Add(firstAid);
            lstRemoveFirstAid.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteFirstAidListBox();

        }

        private void lstFirstAid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmFirstAid_Load(object sender, EventArgs e)
        {
            PopulateFirstAidListBox();
            PopulateDeleteFirstAidListBox();
        }

        private void btnDeleteFirstAid_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstRemoveFirstAid.SelectedItem;
            UserInventory firstAid = dbContext.UserInventories.FirstOrDefault(firstAid => firstAid.FirstAid == chosenItem);
            dbContext.UserInventories.Remove(firstAid);
            lstRemoveFirstAid.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteFirstAidListBox();
        }

        private void lstRemoveFirstAid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
