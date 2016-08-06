namespace MovieBonanza
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backButtonAtOrderForm = new System.Windows.Forms.Button();
            this.CancelbuttonAtOrderForm = new System.Windows.Forms.Button();
            this.StreamButtonAtOrderForm = new System.Windows.Forms.Button();
            this.MovieSelectedGroupBoxAtOrderForm = new System.Windows.Forms.GroupBox();
            this.OrderGroupBoxAtOrderForm = new System.Windows.Forms.GroupBox();
            this.TitleTextBoxAtOF = new System.Windows.Forms.TextBox();
            this.CategoryTextBoxAtOF = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.costTxtBx = new System.Windows.Forms.TextBox();
            this.SubTotalTxtBx = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBx = new System.Windows.Forms.TextBox();
            this.GrandTotalTxtBx = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.subTotalLbl = new System.Windows.Forms.Label();
            this.SalesTaxLbl = new System.Windows.Forms.Label();
            this.GrandTotalLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.MovieSelectedGroupBoxAtOrderForm.SuspendLayout();
            this.OrderGroupBoxAtOrderForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+H";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+M";
            this.streamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // backButtonAtOrderForm
            // 
            this.backButtonAtOrderForm.Location = new System.Drawing.Point(439, 338);
            this.backButtonAtOrderForm.Name = "backButtonAtOrderForm";
            this.backButtonAtOrderForm.Size = new System.Drawing.Size(75, 23);
            this.backButtonAtOrderForm.TabIndex = 1;
            this.backButtonAtOrderForm.Text = "Back";
            this.backButtonAtOrderForm.UseVisualStyleBackColor = true;
            // 
            // CancelbuttonAtOrderForm
            // 
            this.CancelbuttonAtOrderForm.Location = new System.Drawing.Point(567, 338);
            this.CancelbuttonAtOrderForm.Name = "CancelbuttonAtOrderForm";
            this.CancelbuttonAtOrderForm.Size = new System.Drawing.Size(75, 23);
            this.CancelbuttonAtOrderForm.TabIndex = 2;
            this.CancelbuttonAtOrderForm.Text = "Cancel";
            this.CancelbuttonAtOrderForm.UseVisualStyleBackColor = true;
            // 
            // StreamButtonAtOrderForm
            // 
            this.StreamButtonAtOrderForm.Location = new System.Drawing.Point(685, 338);
            this.StreamButtonAtOrderForm.Name = "StreamButtonAtOrderForm";
            this.StreamButtonAtOrderForm.Size = new System.Drawing.Size(75, 23);
            this.StreamButtonAtOrderForm.TabIndex = 3;
            this.StreamButtonAtOrderForm.Text = "Stream";
            this.StreamButtonAtOrderForm.UseVisualStyleBackColor = true;
            // 
            // MovieSelectedGroupBoxAtOrderForm
            // 
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.pictureBox1);
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.CategoryLbl);
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.CategoryTextBoxAtOF);
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.TitleTextBoxAtOF);
            this.MovieSelectedGroupBoxAtOrderForm.Location = new System.Drawing.Point(24, 38);
            this.MovieSelectedGroupBoxAtOrderForm.Name = "MovieSelectedGroupBoxAtOrderForm";
            this.MovieSelectedGroupBoxAtOrderForm.Size = new System.Drawing.Size(269, 344);
            this.MovieSelectedGroupBoxAtOrderForm.TabIndex = 4;
            this.MovieSelectedGroupBoxAtOrderForm.TabStop = false;
            this.MovieSelectedGroupBoxAtOrderForm.Text = "Movie Selected";
            // 
            // OrderGroupBoxAtOrderForm
            // 
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.GrandTotalLbl);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.SalesTaxLbl);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.subTotalLbl);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.costLabel);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.GrandTotalTxtBx);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.SalesTaxTextBx);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.SubTotalTxtBx);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.costTxtBx);
            this.OrderGroupBoxAtOrderForm.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGroupBoxAtOrderForm.Location = new System.Drawing.Point(316, 48);
            this.OrderGroupBoxAtOrderForm.Name = "OrderGroupBoxAtOrderForm";
            this.OrderGroupBoxAtOrderForm.Size = new System.Drawing.Size(444, 266);
            this.OrderGroupBoxAtOrderForm.TabIndex = 5;
            this.OrderGroupBoxAtOrderForm.TabStop = false;
            this.OrderGroupBoxAtOrderForm.Text = "Your Order";
            // 
            // TitleTextBoxAtOF
            // 
            this.TitleTextBoxAtOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TitleTextBoxAtOF.Location = new System.Drawing.Point(6, 40);
            this.TitleTextBoxAtOF.Name = "TitleTextBoxAtOF";
            this.TitleTextBoxAtOF.ReadOnly = true;
            this.TitleTextBoxAtOF.Size = new System.Drawing.Size(240, 26);
            this.TitleTextBoxAtOF.TabIndex = 0;
            // 
            // CategoryTextBoxAtOF
            // 
            this.CategoryTextBoxAtOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CategoryTextBoxAtOF.Location = new System.Drawing.Point(6, 102);
            this.CategoryTextBoxAtOF.Name = "CategoryTextBoxAtOF";
            this.CategoryTextBoxAtOF.ReadOnly = true;
            this.CategoryTextBoxAtOF.Size = new System.Drawing.Size(240, 26);
            this.CategoryTextBoxAtOF.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.TitleLabel.Location = new System.Drawing.Point(3, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(45, 23);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.Location = new System.Drawing.Point(6, 76);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(84, 23);
            this.CategoryLbl.TabIndex = 3;
            this.CategoryLbl.Text = "Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 193);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // costTxtBx
            // 
            this.costTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.costTxtBx.Location = new System.Drawing.Point(208, 30);
            this.costTxtBx.Name = "costTxtBx";
            this.costTxtBx.Size = new System.Drawing.Size(142, 26);
            this.costTxtBx.TabIndex = 0;
            this.costTxtBx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SubTotalTxtBx
            // 
            this.SubTotalTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SubTotalTxtBx.Location = new System.Drawing.Point(208, 73);
            this.SubTotalTxtBx.Name = "SubTotalTxtBx";
            this.SubTotalTxtBx.Size = new System.Drawing.Size(142, 26);
            this.SubTotalTxtBx.TabIndex = 1;
            // 
            // SalesTaxTextBx
            // 
            this.SalesTaxTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SalesTaxTextBx.Location = new System.Drawing.Point(208, 124);
            this.SalesTaxTextBx.Name = "SalesTaxTextBx";
            this.SalesTaxTextBx.Size = new System.Drawing.Size(142, 26);
            this.SalesTaxTextBx.TabIndex = 2;
            // 
            // GrandTotalTxtBx
            // 
            this.GrandTotalTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GrandTotalTxtBx.Location = new System.Drawing.Point(208, 168);
            this.GrandTotalTxtBx.Name = "GrandTotalTxtBx";
            this.GrandTotalTxtBx.Size = new System.Drawing.Size(142, 26);
            this.GrandTotalTxtBx.TabIndex = 3;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.costLabel.Location = new System.Drawing.Point(155, 25);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(43, 23);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "cost";
            // 
            // subTotalLbl
            // 
            this.subTotalLbl.AutoSize = true;
            this.subTotalLbl.Font = new System.Drawing.Font("Tahoma", 14F);
            this.subTotalLbl.Location = new System.Drawing.Point(114, 73);
            this.subTotalLbl.Name = "subTotalLbl";
            this.subTotalLbl.Size = new System.Drawing.Size(84, 23);
            this.subTotalLbl.TabIndex = 5;
            this.subTotalLbl.Text = "SubTotal";
            // 
            // SalesTaxLbl
            // 
            this.SalesTaxLbl.AutoSize = true;
            this.SalesTaxLbl.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SalesTaxLbl.Location = new System.Drawing.Point(56, 127);
            this.SalesTaxLbl.Name = "SalesTaxLbl";
            this.SalesTaxLbl.Size = new System.Drawing.Size(142, 23);
            this.SalesTaxLbl.TabIndex = 6;
            this.SalesTaxLbl.Text = "Sales Tax(13%)";
            // 
            // GrandTotalLbl
            // 
            this.GrandTotalLbl.AutoSize = true;
            this.GrandTotalLbl.Font = new System.Drawing.Font("Tahoma", 14F);
            this.GrandTotalLbl.Location = new System.Drawing.Point(89, 168);
            this.GrandTotalLbl.Name = "GrandTotalLbl";
            this.GrandTotalLbl.Size = new System.Drawing.Size(109, 23);
            this.GrandTotalLbl.TabIndex = 7;
            this.GrandTotalLbl.Text = "Grand Total";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 394);
            this.Controls.Add(this.OrderGroupBoxAtOrderForm);
            this.Controls.Add(this.MovieSelectedGroupBoxAtOrderForm);
            this.Controls.Add(this.StreamButtonAtOrderForm);
            this.Controls.Add(this.CancelbuttonAtOrderForm);
            this.Controls.Add(this.backButtonAtOrderForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MovieSelectedGroupBoxAtOrderForm.ResumeLayout(false);
            this.MovieSelectedGroupBoxAtOrderForm.PerformLayout();
            this.OrderGroupBoxAtOrderForm.ResumeLayout(false);
            this.OrderGroupBoxAtOrderForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button backButtonAtOrderForm;
        private System.Windows.Forms.Button CancelbuttonAtOrderForm;
        private System.Windows.Forms.Button StreamButtonAtOrderForm;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBoxAtOrderForm;
        private System.Windows.Forms.TextBox CategoryTextBoxAtOF;
        private System.Windows.Forms.TextBox TitleTextBoxAtOF;
        private System.Windows.Forms.GroupBox OrderGroupBoxAtOrderForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox GrandTotalTxtBx;
        private System.Windows.Forms.TextBox SalesTaxTextBx;
        private System.Windows.Forms.TextBox SubTotalTxtBx;
        private System.Windows.Forms.TextBox costTxtBx;
        private System.Windows.Forms.Label GrandTotalLbl;
        private System.Windows.Forms.Label SalesTaxLbl;
        private System.Windows.Forms.Label subTotalLbl;
        private System.Windows.Forms.Label costLabel;
    }
}