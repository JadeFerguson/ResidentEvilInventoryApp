namespace ResidentEvilInventoryApp
{
    partial class Herbs
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
            // 
            // lstHerbs
            // 
            this.lstHerbs.FormattingEnabled = true;
            this.lstHerbs.ItemHeight = 37;
            this.lstHerbs.Location = new System.Drawing.Point(48, 53);
            this.lstHerbs.Name = "lstHerbs";
            this.lstHerbs.Size = new System.Drawing.Size(269, 337);
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
            // 
            // Herbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstHerbs);
            this.Controls.Add(this.btnAddHerbs);
            this.Name = "Herbs";
            this.Text = "Herbs";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddHerbs;
        private ListBox lstHerbs;
        private Button btnDelete;
    }
}