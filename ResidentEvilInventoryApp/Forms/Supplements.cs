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
    public partial class frmSupplements : Form
    {
        public frmSupplements()
        {
            InitializeComponent();
        }

        private void PopulateSupplementsListBox()
        {
            lstSupplements.Items.Add("Supplement");
        }

        private void PopulateDeleteSupplementsListBox()
        {
            InventoryContext dbContext = new();
            List<UserInventory> userInventories = (from item in dbContext.UserInventories
                                                   where item.Supplements != null
                                                   select item).ToList();
            foreach (UserInventory item in userInventories)
            {
                lstRemoveSupplements.Items.Add(item.Supplements);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstSupplements.SelectedItem;
            var supplement = new UserInventory { Supplements = chosenItem };
            dbContext.UserInventories.Add(supplement);
            lstRemoveSupplements.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteSupplementsListBox();
        }

        private void frmSupplements_Load(object sender, EventArgs e)
        {
            PopulateSupplementsListBox();
            PopulateDeleteSupplementsListBox();
        }

        private void btnDeleteSupp_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstRemoveSupplements.SelectedItem;
            UserInventory supplement = dbContext.UserInventories.FirstOrDefault(supplement => supplement.Supplements == chosenItem);
            dbContext.UserInventories.Remove(supplement);
            lstRemoveSupplements.Items.Clear();
            dbContext.SaveChanges();
            PopulateDeleteSupplementsListBox();
        }
    }
}
