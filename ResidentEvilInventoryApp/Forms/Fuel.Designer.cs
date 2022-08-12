namespace ResidentEvilInventoryApp
{
    partial class frmFuel
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
            this.btnAddFuel = new System.Windows.Forms.Button();
            this.lstFuel = new System.Windows.Forms.ListBox();
            this.btnDeleteFuel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFuel
            // 
            this.btnAddFuel.Location = new System.Drawing.Point(417, 59);
            this.btnAddFuel.Name = "btnAddFuel";
            this.btnAddFuel.Size = new System.Drawing.Size(333, 107);
            this.btnAddFuel.TabIndex = 0;
            this.btnAddFuel.Text = "Add";
            this.btnAddFuel.UseVisualStyleBackColor = true;
            // 
            // lstFuel
            // 
            this.lstFuel.FormattingEnabled = true;
            this.lstFuel.ItemHeight = 37;
            this.lstFuel.Location = new System.Drawing.Point(54, 59);
            this.lstFuel.Name = "lstFuel";
            this.lstFuel.Size = new System.Drawing.Size(277, 337);
            this.lstFuel.TabIndex = 1;
            // 
            // btnDeleteFuel
            // 
            this.btnDeleteFuel.Location = new System.Drawing.Point(417, 289);
            this.btnDeleteFuel.Name = "btnDeleteFuel";
            this.btnDeleteFuel.Size = new System.Drawing.Size(333, 107);
            this.btnDeleteFuel.TabIndex = 2;
            this.btnDeleteFuel.Text = "Delete";
            this.btnDeleteFuel.UseVisualStyleBackColor = true;
            // 
            // frmFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteFuel);
            this.Controls.Add(this.lstFuel);
            this.Controls.Add(this.btnAddFuel);
            this.Name = "frmFuel";
            this.Text = "Fuel";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddFuel;
        private ListBox lstFuel;
        private Button btnDeleteFuel;
    }
}