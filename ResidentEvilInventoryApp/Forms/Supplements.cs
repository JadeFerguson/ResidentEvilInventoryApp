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

        private void button1_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstSupplements.SelectedItem;
            var supplement = new UserInventory { Supplements = chosenItem };
            dbContext.UserInventories.Add(supplement);
            dbContext.SaveChanges();
        }

        private void frmSupplements_Load(object sender, EventArgs e)
        {
            PopulateSupplementsListBox();
        }
    }
}
