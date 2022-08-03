namespace ResidentEvilInventoryApp
{
    partial class Misc
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
            this.btnAddMisc.Location = new System.Drawing.Point(418, 76);
            this.btnAddMisc.Name = "btnAddMisc";
            this.btnAddMisc.Size = new System.Drawing.Size(308, 116);
            this.btnAddMisc.TabIndex = 0;
            this.btnAddMisc.Text = "Add";
            this.btnAddMisc.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMisc
            // 
            this.btnDeleteMisc.Location = new System.Drawing.Point(418, 263);
            this.btnDeleteMisc.Name = "btnDeleteMisc";
            this.btnDeleteMisc.Size = new System.Drawing.Size(308, 113);
            this.btnDeleteMisc.TabIndex = 1;
            this.btnDeleteMisc.Text = "Delete";
            this.btnDeleteMisc.UseVisualStyleBackColor = true;
            // 
            // lstMisc
            // 
            this.lstMisc.FormattingEnabled = true;
            this.lstMisc.ItemHeight = 37;
            this.lstMisc.Location = new System.Drawing.Point(45, 76);
            this.lstMisc.Name = "lstMisc";
            this.lstMisc.Size = new System.Drawing.Size(272, 300);
            this.lstMisc.TabIndex = 2;
            // 
            // Misc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMisc);
            this.Controls.Add(this.btnDeleteMisc);
            this.Controls.Add(this.btnAddMisc);
            this.Name = "Misc";
            this.Text = "Misc";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddMisc;
        private Button btnDeleteMisc;
        private ListBox lstMisc;
    }
}