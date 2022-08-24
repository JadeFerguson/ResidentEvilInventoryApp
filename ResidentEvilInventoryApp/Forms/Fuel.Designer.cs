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
            this.lstRemoveFuel = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnAddFuel.Click += new System.EventHandler(this.btnAddFuel_Click);
            // 
            // lstFuel
            // 
            this.lstFuel.FormattingEnabled = true;
            this.lstFuel.ItemHeight = 37;
            this.lstFuel.Location = new System.Drawing.Point(54, 59);
            this.lstFuel.Name = "lstFuel";
            this.lstFuel.Size = new System.Drawing.Size(277, 152);
            this.lstFuel.TabIndex = 1;
            this.lstFuel.SelectedIndexChanged += new System.EventHandler(this.lstFuel_SelectedIndexChanged);
            // 
            // btnDeleteFuel
            // 
            this.btnDeleteFuel.Location = new System.Drawing.Point(417, 289);
            this.btnDeleteFuel.Name = "btnDeleteFuel";
            this.btnDeleteFuel.Size = new System.Drawing.Size(333, 107);
            this.btnDeleteFuel.TabIndex = 2;
            this.btnDeleteFuel.Text = "Delete";
            this.btnDeleteFuel.UseVisualStyleBackColor = true;
            this.btnDeleteFuel.Click += new System.EventHandler(this.btnDeleteFuel_Click);
            // 
            // lstRemoveFuel
            // 
            this.lstRemoveFuel.FormattingEnabled = true;
            this.lstRemoveFuel.ItemHeight = 37;
            this.lstRemoveFuel.Location = new System.Drawing.Point(54, 267);
            this.lstRemoveFuel.Name = "lstRemoveFuel";
            this.lstRemoveFuel.Size = new System.Drawing.Size(277, 152);
            this.lstRemoveFuel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click from list to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click from list to delete";
            // 
            // frmFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRemoveFuel);
            this.Controls.Add(this.btnDeleteFuel);
            this.Controls.Add(this.lstFuel);
            this.Controls.Add(this.btnAddFuel);
            this.Name = "frmFuel";
            this.Text = "Fuel";
            this.Load += new System.EventHandler(this.frmFuel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddFuel;
        private ListBox lstFuel;
        private Button btnDeleteFuel;
        private ListBox lstRemoveFuel;
        private Label label1;
        private Label label2;
    }
}