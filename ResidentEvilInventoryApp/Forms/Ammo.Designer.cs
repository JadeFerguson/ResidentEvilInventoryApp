namespace ResidentEvilInventoryApp
{
    partial class frmAmmo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddAmmo = new System.Windows.Forms.Button();
            this.lstAmmo = new System.Windows.Forms.ListBox();
            this.btnDeleteAmmo = new System.Windows.Forms.Button();
            this.lstRemoveAmmo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAmmo
            // 
            this.btnAddAmmo.Location = new System.Drawing.Point(398, 56);
            this.btnAddAmmo.Name = "btnAddAmmo";
            this.btnAddAmmo.Size = new System.Drawing.Size(336, 104);
            this.btnAddAmmo.TabIndex = 0;
            this.btnAddAmmo.Text = "Add";
            this.btnAddAmmo.UseVisualStyleBackColor = true;
            this.btnAddAmmo.Click += new System.EventHandler(this.btnAddAmmo_Click);
            // 
            // lstAmmo
            // 
            this.lstAmmo.FormattingEnabled = true;
            this.lstAmmo.ItemHeight = 37;
            this.lstAmmo.Location = new System.Drawing.Point(40, 47);
            this.lstAmmo.Name = "lstAmmo";
            this.lstAmmo.Size = new System.Drawing.Size(297, 152);
            this.lstAmmo.TabIndex = 1;
            // 
            // btnDeleteAmmo
            // 
            this.btnDeleteAmmo.Location = new System.Drawing.Point(398, 289);
            this.btnDeleteAmmo.Name = "btnDeleteAmmo";
            this.btnDeleteAmmo.Size = new System.Drawing.Size(336, 104);
            this.btnDeleteAmmo.TabIndex = 2;
            this.btnDeleteAmmo.Text = "Delete";
            this.btnDeleteAmmo.UseVisualStyleBackColor = true;
            this.btnDeleteAmmo.Click += new System.EventHandler(this.btnDeleteAmmo_Click);
            // 
            // lstRemoveAmmo
            // 
            this.lstRemoveAmmo.FormattingEnabled = true;
            this.lstRemoveAmmo.ItemHeight = 37;
            this.lstRemoveAmmo.Location = new System.Drawing.Point(40, 276);
            this.lstRemoveAmmo.Name = "lstRemoveAmmo";
            this.lstRemoveAmmo.Size = new System.Drawing.Size(297, 152);
            this.lstRemoveAmmo.TabIndex = 3;
            this.lstRemoveAmmo.SelectedIndexChanged += new System.EventHandler(this.lstRemoveAmmo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click to from list to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click from list to delete";
            // 
            // frmAmmo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRemoveAmmo);
            this.Controls.Add(this.btnDeleteAmmo);
            this.Controls.Add(this.lstAmmo);
            this.Controls.Add(this.btnAddAmmo);
            this.Name = "frmAmmo";
            this.Text = "Ammo";
            this.Load += new System.EventHandler(this.frmAmmo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddAmmo;
        private ListBox lstAmmo;
        private Button btnDeleteAmmo;
        private ListBox lstRemoveAmmo;
        private Label label1;
        private Label label2;
    }
}