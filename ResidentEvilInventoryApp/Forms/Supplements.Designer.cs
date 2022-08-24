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
            this.lstRemoveSupplements = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            // 
            // lstSupplements
            // 
            this.lstSupplements.FormattingEnabled = true;
            this.lstSupplements.ItemHeight = 37;
            this.lstSupplements.Location = new System.Drawing.Point(55, 59);
            this.lstSupplements.Name = "lstSupplements";
            this.lstSupplements.Size = new System.Drawing.Size(270, 152);
            this.lstSupplements.TabIndex = 2;
            // 
            // lstRemoveSupplements
            // 
            this.lstRemoveSupplements.FormattingEnabled = true;
            this.lstRemoveSupplements.ItemHeight = 37;
            this.lstRemoveSupplements.Location = new System.Drawing.Point(55, 262);
            this.lstRemoveSupplements.Name = "lstRemoveSupplements";
            this.lstRemoveSupplements.Size = new System.Drawing.Size(270, 152);
            this.lstRemoveSupplements.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click from list to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click from list to delete";
            // 
            // frmSupplements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRemoveSupplements);
            this.Controls.Add(this.lstSupplements);
            this.Controls.Add(this.btnDeleteSupp);
            this.Controls.Add(this.btnAddSupp);
            this.Name = "frmSupplements";
            this.Text = "Supplements";
            this.Load += new System.EventHandler(this.frmSupplements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddSupp;
        private Button btnDeleteSupp;
        private ListBox lstSupplements;
        private ListBox lstRemoveSupplements;
        private Label label1;
        private Label label2;
    }
}