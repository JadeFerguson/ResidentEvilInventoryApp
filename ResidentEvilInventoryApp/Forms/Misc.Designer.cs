namespace ResidentEvilInventoryApp
{
    partial class frmMisc
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
            this.btnAddMisc = new System.Windows.Forms.Button();
            this.btnDeleteMisc = new System.Windows.Forms.Button();
            this.lstMisc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddMisc
            // 
            this.btnAddMisc.Location = new System.Drawing.Point(279, 51);
            this.btnAddMisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMisc.Name = "btnAddMisc";
            this.btnAddMisc.Size = new System.Drawing.Size(205, 78);
            this.btnAddMisc.TabIndex = 0;
            this.btnAddMisc.Text = "Add";
            this.btnAddMisc.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMisc
            // 
            this.btnDeleteMisc.Location = new System.Drawing.Point(279, 178);
            this.btnDeleteMisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteMisc.Name = "btnDeleteMisc";
            this.btnDeleteMisc.Size = new System.Drawing.Size(205, 76);
            this.btnDeleteMisc.TabIndex = 1;
            this.btnDeleteMisc.Text = "Delete";
            this.btnDeleteMisc.UseVisualStyleBackColor = true;
            // 
            // lstMisc
            // 
            this.lstMisc.FormattingEnabled = true;
            this.lstMisc.ItemHeight = 25;
            this.lstMisc.Location = new System.Drawing.Point(30, 51);
            this.lstMisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMisc.Name = "lstMisc";
            this.lstMisc.Size = new System.Drawing.Size(183, 204);
            this.lstMisc.TabIndex = 2;
            // 
            // frmMisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 304);
            this.Controls.Add(this.lstMisc);
            this.Controls.Add(this.btnDeleteMisc);
            this.Controls.Add(this.btnAddMisc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMisc";
            this.Text = "Misc";
            this.Load += new System.EventHandler(this.frmMisc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddMisc;
        private Button btnDeleteMisc;
        private ListBox lstMisc;
    }
}