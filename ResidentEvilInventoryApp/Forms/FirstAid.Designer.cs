namespace ResidentEvilInventoryApp
{
    partial class frmFirstAid
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
            this.btnAddFirstAid = new System.Windows.Forms.Button();
            this.btnDeleteFirstAid = new System.Windows.Forms.Button();
            this.lstFirstAid = new System.Windows.Forms.ListBox();
            this.lstRemoveFirstAid = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddFirstAid
            // 
            this.btnAddFirstAid.Location = new System.Drawing.Point(285, 46);
            this.btnAddFirstAid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddFirstAid.Name = "btnAddFirstAid";
            this.btnAddFirstAid.Size = new System.Drawing.Size(194, 81);
            this.btnAddFirstAid.TabIndex = 0;
            this.btnAddFirstAid.Text = "Add";
            this.btnAddFirstAid.UseVisualStyleBackColor = true;
            this.btnAddFirstAid.Click += new System.EventHandler(this.btnAddFirstAid_Click);
            // 
            // btnDeleteFirstAid
            // 
            this.btnDeleteFirstAid.Location = new System.Drawing.Point(285, 187);
            this.btnDeleteFirstAid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteFirstAid.Name = "btnDeleteFirstAid";
            this.btnDeleteFirstAid.Size = new System.Drawing.Size(194, 86);
            this.btnDeleteFirstAid.TabIndex = 1;
            this.btnDeleteFirstAid.Text = "Delete";
            this.btnDeleteFirstAid.UseVisualStyleBackColor = true;
            this.btnDeleteFirstAid.Click += new System.EventHandler(this.btnDeleteFirstAid_Click);
            // 
            // lstFirstAid
            // 
            this.lstFirstAid.FormattingEnabled = true;
            this.lstFirstAid.ItemHeight = 25;
            this.lstFirstAid.Location = new System.Drawing.Point(33, 36);
            this.lstFirstAid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstFirstAid.Name = "lstFirstAid";
            this.lstFirstAid.Size = new System.Drawing.Size(189, 104);
            this.lstFirstAid.TabIndex = 2;
            this.lstFirstAid.SelectedIndexChanged += new System.EventHandler(this.lstFirstAid_SelectedIndexChanged);
            // 
            // lstRemoveFirstAid
            // 
            this.lstRemoveFirstAid.FormattingEnabled = true;
            this.lstRemoveFirstAid.ItemHeight = 25;
            this.lstRemoveFirstAid.Location = new System.Drawing.Point(33, 187);
            this.lstRemoveFirstAid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstRemoveFirstAid.Name = "lstRemoveFirstAid";
            this.lstRemoveFirstAid.Size = new System.Drawing.Size(189, 104);
            this.lstRemoveFirstAid.TabIndex = 3;
            this.lstRemoveFirstAid.SelectedIndexChanged += new System.EventHandler(this.lstRemoveFirstAid_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click from list to add ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click from list to delete";
            // 
            // frmFirstAid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRemoveFirstAid);
            this.Controls.Add(this.lstFirstAid);
            this.Controls.Add(this.btnDeleteFirstAid);
            this.Controls.Add(this.btnAddFirstAid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmFirstAid";
            this.Text = "First Aid";
            this.Load += new System.EventHandler(this.frmFirstAid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddFirstAid;
        private Button btnDeleteFirstAid;
        private ListBox lstFirstAid;
        private ListBox lstRemoveFirstAid;
        private Label label1;
        private Label label2;
    }
}