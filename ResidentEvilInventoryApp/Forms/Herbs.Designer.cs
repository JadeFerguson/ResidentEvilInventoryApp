namespace ResidentEvilInventoryApp
{
    partial class frmHerbs
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
            this.btnAddHerbs = new System.Windows.Forms.Button();
            this.lstHerbs = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstRemoveHerb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddHerbs
            // 
            this.btnAddHerbs.Location = new System.Drawing.Point(413, 53);
            this.btnAddHerbs.Name = "btnAddHerbs";
            this.btnAddHerbs.Size = new System.Drawing.Size(323, 102);
            this.btnAddHerbs.TabIndex = 0;
            this.btnAddHerbs.Text = "Add";
            this.btnAddHerbs.UseVisualStyleBackColor = true;
            this.btnAddHerbs.Click += new System.EventHandler(this.btnAddHerbs_Click);
            // 
            // lstHerbs
            // 
            this.lstHerbs.FormattingEnabled = true;
            this.lstHerbs.ItemHeight = 37;
            this.lstHerbs.Location = new System.Drawing.Point(48, 53);
            this.lstHerbs.Name = "lstHerbs";
            this.lstHerbs.Size = new System.Drawing.Size(269, 152);
            this.lstHerbs.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(323, 108);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstRemoveHerb
            // 
            this.lstRemoveHerb.FormattingEnabled = true;
            this.lstRemoveHerb.ItemHeight = 37;
            this.lstRemoveHerb.Location = new System.Drawing.Point(48, 261);
            this.lstRemoveHerb.Name = "lstRemoveHerb";
            this.lstRemoveHerb.Size = new System.Drawing.Size(269, 152);
            this.lstRemoveHerb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click from list to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click from list to delete";
            // 
            // frmHerbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRemoveHerb);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstHerbs);
            this.Controls.Add(this.btnAddHerbs);
            this.Name = "frmHerbs";
            this.Text = "Herbs";
            this.Load += new System.EventHandler(this.frmHerbs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddHerbs;
        private ListBox lstHerbs;
        private Button btnDelete;
        private ListBox lstRemoveHerb;
        private Label label1;
        private Label label2;
    }
}