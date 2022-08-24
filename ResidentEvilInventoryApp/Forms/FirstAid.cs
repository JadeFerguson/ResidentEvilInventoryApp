﻿using System;
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

        private void btnAddFirstAid_Click(object sender, EventArgs e)
        {
            InventoryContext dbContext = new();

            string chosenItem = (string)lstFirstAid.SelectedItem;
            var firstAid = new UserInventory { FirstAid = chosenItem };
            dbContext.UserInventories.Add(firstAid);
            dbContext.SaveChanges();

        }

        private void lstFirstAid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmFirstAid_Load(object sender, EventArgs e)
        {
            PopulateFirstAidListBox();
        }
    }
}
