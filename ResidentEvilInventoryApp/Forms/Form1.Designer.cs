namespace ResidentEvilInventoryApp
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btnWeapons
            // 
            this.btnWeapons.Location = new System.Drawing.Point(667, 590);
            this.btnWeapons.Margin = new System.Windows.Forms.Padding(2);
            this.btnWeapons.Name = "btnWeapons";
            this.btnWeapons.Size = new System.Drawing.Size(133, 46);
            this.btnWeapons.TabIndex = 0;
            this.btnWeapons.Text = "Weapons";
            this.btnWeapons.UseVisualStyleBackColor = true;
            // 
            // btnFirstAid
            // 
            this.btnFirstAid.Location = new System.Drawing.Point(667, 505);
            this.btnFirstAid.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstAid.Name = "btnFirstAid";
            this.btnFirstAid.Size = new System.Drawing.Size(133, 46);
            this.btnFirstAid.TabIndex = 1;
            this.btnFirstAid.Text = "First Aid";
            this.btnFirstAid.UseVisualStyleBackColor = true;
            // 
            // Ammo
            // 
            this.Ammo.Location = new System.Drawing.Point(667, 393);
            this.Ammo.Margin = new System.Windows.Forms.Padding(2);
            this.Ammo.Name = "Ammo";
            this.Ammo.Size = new System.Drawing.Size(133, 47);
            this.Ammo.TabIndex = 2;
            this.Ammo.Text = "Ammo";
            this.Ammo.UseVisualStyleBackColor = true;
            // 
            // btnFuel
            // 
            this.btnFuel.Location = new System.Drawing.Point(651, 11);
            this.btnFuel.Margin = new System.Windows.Forms.Padding(2);
            this.btnFuel.Name = "btnFuel";
            this.btnFuel.Size = new System.Drawing.Size(149, 46);
            this.btnFuel.TabIndex = 3;
            this.btnFuel.Text = "Fuel";
            this.btnFuel.UseVisualStyleBackColor = true;
            // 
            // btnHerbs
            // 
            this.btnHerbs.Location = new System.Drawing.Point(655, 200);
            this.btnHerbs.Margin = new System.Windows.Forms.Padding(2);
            this.btnHerbs.Name = "btnHerbs";
            this.btnHerbs.Size = new System.Drawing.Size(145, 46);
            this.btnHerbs.TabIndex = 4;
            this.btnHerbs.Text = "Herbs";
            this.btnHerbs.UseVisualStyleBackColor = true;
            // 
            // btnSupplements
            // 
            this.btnSupplements.Location = new System.Drawing.Point(656, 296);
            this.btnSupplements.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupplements.Name = "btnSupplements";
            this.btnSupplements.Size = new System.Drawing.Size(144, 47);
            this.btnSupplements.TabIndex = 5;
            this.btnSupplements.Text = "Supplements";
            this.btnSupplements.UseVisualStyleBackColor = true;
            // 
            // btnMisc
            // 
            this.btnMisc.Location = new System.Drawing.Point(677, 103);
            this.btnMisc.Margin = new System.Windows.Forms.Padding(2);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(123, 46);
            this.btnMisc.TabIndex = 6;
            this.btnMisc.Text = "Misc.";
            this.btnMisc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 698);
            this.Controls.Add(this.btnMisc);
            this.Controls.Add(this.btnSupplements);
            this.Controls.Add(this.btnHerbs);
            this.Controls.Add(this.btnFuel);
            this.Controls.Add(this.Ammo);
            this.Controls.Add(this.btnFirstAid);
            this.Controls.Add(this.btnWeapons);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnWeapons;
        private Button btnFirstAid;
        private Button Ammo;
        private Button btnFuel;
        private Button btnHerbs;
        private Button btnSupplements;
        private Button btnMisc;
    }
}