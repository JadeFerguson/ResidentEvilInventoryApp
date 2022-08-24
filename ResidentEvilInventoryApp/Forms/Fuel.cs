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

        private void lstFuel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFuel_Load(object sender, EventArgs e)
        {
            PopulateFuelListBox();
        }

        private void btnAddFuel_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();
            
            string chosenItem = (string)lstFuel.SelectedItem;
            var fuel = new UserInventory { Fuel = chosenItem };
            dbContext.UserInventories.Add(fuel);
            dbContext.SaveChanges();

            // for self to check how many things 
            /*int count = (from inventory in dbContext.UserInventories
                                select inventory).Count();
            MessageBox.Show(count.ToString());*/
            
        }
    }
}
