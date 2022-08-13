namespace ResidentEvilInventoryApp
{
    partial class frmSupplements
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
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.btnDeleteSupp = new System.Windows.Forms.Button();
            this.lstSupplements = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.Location = new System.Drawing.Point(406, 59);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(327, 92);
            this.btnAddSupp.TabIndex = 0;
            this.btnAddSupp.Text = "Add";
            this.btnAddSupp.UseVisualStyleBackColor = true;
            this.btnAddSupp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.Location = new System.Drawing.Point(406, 291);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.Size = new System.Drawing.Size(327, 105);
            this.btnDeleteSupp.TabIndex = 1;
            this.btnDeleteSupp.Text = "Delete";
            this.btnDeleteSupp.UseVisualStyleBackColor = true;
            // 
            // lstSupplements
            // 
            this.lstSupplements.FormattingEnabled = true;
            this.lstSupplements.ItemHeight = 37;
            this.lstSupplements.Location = new System.Drawing.Point(55, 59);
            this.lstSupplements.Name = "lstSupplements";
            this.lstSupplements.Size = new System.Drawing.Size(270, 337);
            this.lstSupplements.TabIndex = 2;
            // 
            // frmSupplements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSupplements);
            this.Controls.Add(this.btnDeleteSupp);
            this.Controls.Add(this.btnAddSupp);
            this.Name = "frmSupplements";
            this.Text = "Supplements";
            this.Load += new System.EventHandler(this.frmSupplements_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddSupp;
        private Button btnDeleteSupp;
        private ListBox lstSupplements;
    }
}