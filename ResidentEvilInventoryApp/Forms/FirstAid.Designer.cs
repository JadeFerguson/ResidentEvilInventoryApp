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
            this.SuspendLayout();
            // 
            // btnAddFirstAid
            // 
            this.btnAddFirstAid.Location = new System.Drawing.Point(428, 68);
            this.btnAddFirstAid.Name = "btnAddFirstAid";
            this.btnAddFirstAid.Size = new System.Drawing.Size(291, 120);
            this.btnAddFirstAid.TabIndex = 0;
            this.btnAddFirstAid.Text = "Add";
            this.btnAddFirstAid.UseVisualStyleBackColor = true;
            this.btnAddFirstAid.Click += new System.EventHandler(this.btnAddFirstAid_Click);
            // 
            // btnDeleteFirstAid
            // 
            this.btnDeleteFirstAid.Location = new System.Drawing.Point(428, 277);
            this.btnDeleteFirstAid.Name = "btnDeleteFirstAid";
            this.btnDeleteFirstAid.Size = new System.Drawing.Size(291, 128);
            this.btnDeleteFirstAid.TabIndex = 1;
            this.btnDeleteFirstAid.Text = "Delete";
            this.btnDeleteFirstAid.UseVisualStyleBackColor = true;
            // 
            // lstFirstAid
            // 
            this.lstFirstAid.FormattingEnabled = true;
            this.lstFirstAid.ItemHeight = 37;
            this.lstFirstAid.Location = new System.Drawing.Point(49, 68);
            this.lstFirstAid.Name = "lstFirstAid";
            this.lstFirstAid.Size = new System.Drawing.Size(270, 337);
            this.lstFirstAid.TabIndex = 2;
            this.lstFirstAid.SelectedIndexChanged += new System.EventHandler(this.lstFirstAid_SelectedIndexChanged);
            // 
            // frmFirstAid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFirstAid);
            this.Controls.Add(this.btnDeleteFirstAid);
            this.Controls.Add(this.btnAddFirstAid);
            this.Name = "frmFirstAid";
            this.Text = "First Aid";
            this.Load += new System.EventHandler(this.frmFirstAid_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddFirstAid;
        private Button btnDeleteFirstAid;
        private ListBox lstFirstAid;
    }
}