namespace ResidentEvilInventoryApp
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWeapons = new System.Windows.Forms.Button();
            this.btnFirstAid = new System.Windows.Forms.Button();
            this.Ammo = new System.Windows.Forms.Button();
            this.btnFuel = new System.Windows.Forms.Button();
            this.btnHerbs = new System.Windows.Forms.Button();
            this.btnSupplements = new System.Windows.Forms.Button();
            this.btnMisc = new System.Windows.Forms.Button();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWeapons
            // 
            this.btnWeapons.Location = new System.Drawing.Point(982, 873);
            this.btnWeapons.Name = "btnWeapons";
            this.btnWeapons.Size = new System.Drawing.Size(218, 68);
            this.btnWeapons.TabIndex = 0;
            this.btnWeapons.Text = "Weapons";
            this.btnWeapons.UseVisualStyleBackColor = true;
            this.btnWeapons.Click += new System.EventHandler(this.btnWeapons_Click);
            // 
            // btnFirstAid
            // 
            this.btnFirstAid.Location = new System.Drawing.Point(982, 747);
            this.btnFirstAid.Name = "btnFirstAid";
            this.btnFirstAid.Size = new System.Drawing.Size(218, 68);
            this.btnFirstAid.TabIndex = 1;
            this.btnFirstAid.Text = "First Aid";
            this.btnFirstAid.UseVisualStyleBackColor = true;
            this.btnFirstAid.Click += new System.EventHandler(this.btnFirstAid_Click);
            // 
            // Ammo
            // 
            this.Ammo.Location = new System.Drawing.Point(982, 582);
            this.Ammo.Name = "Ammo";
            this.Ammo.Size = new System.Drawing.Size(218, 70);
            this.Ammo.TabIndex = 2;
            this.Ammo.Text = "Ammo";
            this.Ammo.UseVisualStyleBackColor = true;
            this.Ammo.Click += new System.EventHandler(this.Ammo_Click);
            // 
            // btnFuel
            // 
            this.btnFuel.Location = new System.Drawing.Point(976, 16);
            this.btnFuel.Name = "btnFuel";
            this.btnFuel.Size = new System.Drawing.Size(224, 68);
            this.btnFuel.TabIndex = 3;
            this.btnFuel.Text = "Fuel";
            this.btnFuel.UseVisualStyleBackColor = true;
            this.btnFuel.Click += new System.EventHandler(this.btnFuel_Click);
            // 
            // btnHerbs
            // 
            this.btnHerbs.Location = new System.Drawing.Point(982, 296);
            this.btnHerbs.Name = "btnHerbs";
            this.btnHerbs.Size = new System.Drawing.Size(218, 68);
            this.btnHerbs.TabIndex = 4;
            this.btnHerbs.Text = "Herbs";
            this.btnHerbs.UseVisualStyleBackColor = true;
            this.btnHerbs.Click += new System.EventHandler(this.btnHerbs_Click);
            // 
            // btnSupplements
            // 
            this.btnSupplements.Location = new System.Drawing.Point(982, 438);
            this.btnSupplements.Name = "btnSupplements";
            this.btnSupplements.Size = new System.Drawing.Size(218, 70);
            this.btnSupplements.TabIndex = 5;
            this.btnSupplements.Text = "Supplements";
            this.btnSupplements.UseVisualStyleBackColor = true;
            this.btnSupplements.Click += new System.EventHandler(this.btnSupplements_Click);
            // 
            // btnMisc
            // 
            this.btnMisc.Location = new System.Drawing.Point(976, 152);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(224, 68);
            this.btnMisc.TabIndex = 6;
            this.btnMisc.Text = "Misc.";
            this.btnMisc.UseVisualStyleBackColor = true;
            this.btnMisc.Click += new System.EventHandler(this.btnMisc_Click);
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.ItemHeight = 37;
            this.lstInventory.Location = new System.Drawing.Point(57, 741);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(571, 226);
            this.lstInventory.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inventory";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.btnMisc);
            this.Controls.Add(this.btnSupplements);
            this.Controls.Add(this.btnHerbs);
            this.Controls.Add(this.btnFuel);
            this.Controls.Add(this.Ammo);
            this.Controls.Add(this.btnFirstAid);
            this.Controls.Add(this.btnWeapons);
            this.Name = "StartForm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnWeapons;
        private Button btnFirstAid;
        private Button Ammo;
        private Button btnFuel;
        private Button btnHerbs;
        private Button btnSupplements;
        private Button btnMisc;
        private ListBox lstInventory;
        private Label label1;
    }
}