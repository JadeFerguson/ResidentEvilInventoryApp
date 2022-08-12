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
            // 
            // lstAmmo
            // 
            this.lstAmmo.FormattingEnabled = true;
            this.lstAmmo.ItemHeight = 37;
            this.lstAmmo.Location = new System.Drawing.Point(40, 56);
            this.lstAmmo.Name = "lstAmmo";
            this.lstAmmo.Size = new System.Drawing.Size(281, 337);
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
            // 
            // frmAmmo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteAmmo);
            this.Controls.Add(this.lstAmmo);
            this.Controls.Add(this.btnAddAmmo);
            this.Name = "frmAmmo";
            this.Text = "Ammo";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddAmmo;
        private ListBox lstAmmo;
        private Button btnDeleteAmmo;
    }
}