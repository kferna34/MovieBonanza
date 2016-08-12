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
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backButtonAtOrderForm = new System.Windows.Forms.Button();
            this.CancelbuttonAtOrderForm = new System.Windows.Forms.Button();
            this.StreamButtonAtOrderForm = new System.Windows.Forms.Button();
            this.MovieSelectedGroupBoxAtOrderForm = new System.Windows.Forms.GroupBox();
            this.MoviePic = new System.Windows.Forms.PictureBox();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.OrderGroupBoxAtOrderForm = new System.Windows.Forms.GroupBox();
            this.OrderDVDCkBx = new System.Windows.Forms.CheckBox();
            this.hiddenTxtBx = new System.Windows.Forms.TextBox();
            this.hiddenLabel = new System.Windows.Forms.Label();
            this.GrandTotalLbl = new System.Windows.Forms.Label();
            this.SalesTaxLbl = new System.Windows.Forms.Label();
            this.subTotalLbl = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.GrandTotalTxtBx = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBx = new System.Windows.Forms.TextBox();
            this.SubTotalTxtBx = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.MovieSelectedGroupBoxAtOrderForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).BeginInit();
            this.OrderGroupBoxAtOrderForm.SuspendLayout();
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backButtonAtOrderForm
            // 
            this.backButtonAtOrderForm.Location = new System.Drawing.Point(416, 359);
            this.backButtonAtOrderForm.Name = "backButtonAtOrderForm";
            this.backButtonAtOrderForm.Size = new System.Drawing.Size(75, 23);
            this.backButtonAtOrderForm.TabIndex = 1;
            this.backButtonAtOrderForm.Text = "Back";
            this.backButtonAtOrderForm.UseVisualStyleBackColor = true;
            this.backButtonAtOrderForm.Click += new System.EventHandler(this.backButtonAtOrderForm_Click);
            // 
            // CancelbuttonAtOrderForm
            // 
            this.CancelbuttonAtOrderForm.Location = new System.Drawing.Point(539, 359);
            this.CancelbuttonAtOrderForm.Name = "CancelbuttonAtOrderForm";
            this.CancelbuttonAtOrderForm.Size = new System.Drawing.Size(75, 23);
            this.CancelbuttonAtOrderForm.TabIndex = 2;
            this.CancelbuttonAtOrderForm.Text = "Cancel";
            this.CancelbuttonAtOrderForm.UseVisualStyleBackColor = true;
            this.CancelbuttonAtOrderForm.Click += new System.EventHandler(this.CancelbuttonAtOrderForm_Click);
            // 
            // StreamButtonAtOrderForm
            // 
            this.StreamButtonAtOrderForm.Location = new System.Drawing.Point(665, 359);
            this.StreamButtonAtOrderForm.Name = "StreamButtonAtOrderForm";
            this.StreamButtonAtOrderForm.Size = new System.Drawing.Size(75, 23);
            this.StreamButtonAtOrderForm.TabIndex = 3;
            this.StreamButtonAtOrderForm.Text = "Stream";
            this.StreamButtonAtOrderForm.UseVisualStyleBackColor = true;
            this.StreamButtonAtOrderForm.Click += new System.EventHandler(this.StreamButtonAtOrderForm_Click);
            // 
            // MovieSelectedGroupBoxAtOrderForm
            // 
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.MoviePic);
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.CategoryLbl);
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.CategoryTextBox);
            this.MovieSelectedGroupBoxAtOrderForm.Controls.Add(this.TitleTextBox);
            this.MovieSelectedGroupBoxAtOrderForm.Location = new System.Drawing.Point(24, 38);
            this.MovieSelectedGroupBoxAtOrderForm.Name = "MovieSelectedGroupBoxAtOrderForm";
            this.MovieSelectedGroupBoxAtOrderForm.Size = new System.Drawing.Size(269, 344);
            this.MovieSelectedGroupBoxAtOrderForm.TabIndex = 4;
            this.MovieSelectedGroupBoxAtOrderForm.TabStop = false;
            this.MovieSelectedGroupBoxAtOrderForm.Text = "Movie Selected";
            // 
            // MoviePic
            // 
            this.MoviePic.Location = new System.Drawing.Point(11, 137);
            this.MoviePic.Name = "MoviePic";
            this.MoviePic.Size = new System.Drawing.Size(235, 193);
            this.MoviePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MoviePic.TabIndex = 4;
            this.MoviePic.TabStop = false;
            this.MoviePic.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // CategoryTextBox
            // 
            this.CategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CategoryTextBox.Location = new System.Drawing.Point(6, 102);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(240, 26);
            this.CategoryTextBox.TabIndex = 1;
            this.CategoryTextBox.TextChanged += new System.EventHandler(this.CategoryTextBoxAtOF_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TitleTextBox.Location = new System.Drawing.Point(6, 40);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(240, 26);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBoxAtOF_TextChanged);
            // 
            // OrderGroupBoxAtOrderForm
            // 
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.OrderDVDCkBx);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.hiddenTxtBx);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.hiddenLabel);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.GrandTotalLbl);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.SalesTaxLbl);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.subTotalLbl);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.costLabel);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.GrandTotalTxtBx);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.SalesTaxTextBx);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.SubTotalTxtBx);
            this.OrderGroupBoxAtOrderForm.Controls.Add(this.costTextBox);
            this.OrderGroupBoxAtOrderForm.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGroupBoxAtOrderForm.Location = new System.Drawing.Point(316, 27);
            this.OrderGroupBoxAtOrderForm.Name = "OrderGroupBoxAtOrderForm";
            this.OrderGroupBoxAtOrderForm.Size = new System.Drawing.Size(444, 259);
            this.OrderGroupBoxAtOrderForm.TabIndex = 5;
            this.OrderGroupBoxAtOrderForm.TabStop = false;
            this.OrderGroupBoxAtOrderForm.Text = "Your Order";
            this.OrderGroupBoxAtOrderForm.Enter += new System.EventHandler(this.OrderGroupBoxAtOrderForm_Enter);
            // 
            // OrderDVDCkBx
            // 
            this.OrderDVDCkBx.AutoSize = true;
            this.OrderDVDCkBx.Font = new System.Drawing.Font("Tahoma", 12F);
            this.OrderDVDCkBx.Location = new System.Drawing.Point(71, 220);
            this.OrderDVDCkBx.Name = "OrderDVDCkBx";
            this.OrderDVDCkBx.Size = new System.Drawing.Size(314, 23);
            this.OrderDVDCkBx.TabIndex = 10;
            this.OrderDVDCkBx.Text = "Order the DVD (adds $10 to your order)";
            this.OrderDVDCkBx.UseVisualStyleBackColor = true;
            this.OrderDVDCkBx.CheckedChanged += new System.EventHandler(this.OrderDVDCkBx_CheckedChanged);
            // 
            // hiddenTxtBx
            // 
            this.hiddenTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hiddenTxtBx.Font = new System.Drawing.Font("Tahoma", 8F);
            this.hiddenTxtBx.Location = new System.Drawing.Point(146, 56);
            this.hiddenTxtBx.Multiline = true;
            this.hiddenTxtBx.Name = "hiddenTxtBx";
            this.hiddenTxtBx.Size = new System.Drawing.Size(239, 43);
            this.hiddenTxtBx.TabIndex = 9;
            this.hiddenTxtBx.Text = "You have chosen to buy the movie and have it delivered to you.An additional charg" +
    "e of $10.00 will be added to your Bill. ";
            this.hiddenTxtBx.Visible = false;
            this.hiddenTxtBx.TextChanged += new System.EventHandler(this.hiddenTxtBx_TextChanged);
            // 
            // hiddenLabel
            // 
            this.hiddenLabel.AutoSize = true;
            this.hiddenLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.hiddenLabel.Location = new System.Drawing.Point(60, 58);
            this.hiddenLabel.Name = "hiddenLabel";
            this.hiddenLabel.Size = new System.Drawing.Size(69, 17);
            this.hiddenLabel.TabIndex = 8;
            this.hiddenLabel.Text = "Attention:";
            this.hiddenLabel.Visible = false;
            // 
            // GrandTotalLbl
            // 
            this.GrandTotalLbl.AutoSize = true;
            this.GrandTotalLbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GrandTotalLbl.Location = new System.Drawing.Point(119, 183);
            this.GrandTotalLbl.Name = "GrandTotalLbl";
            this.GrandTotalLbl.Size = new System.Drawing.Size(79, 17);
            this.GrandTotalLbl.TabIndex = 7;
            this.GrandTotalLbl.Text = "Grand Total";
            // 
            // SalesTaxLbl
            // 
            this.SalesTaxLbl.AutoSize = true;
            this.SalesTaxLbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SalesTaxLbl.Location = new System.Drawing.Point(97, 148);
            this.SalesTaxLbl.Name = "SalesTaxLbl";
            this.SalesTaxLbl.Size = new System.Drawing.Size(105, 17);
            this.SalesTaxLbl.TabIndex = 6;
            this.SalesTaxLbl.Text = "Sales Tax(13%)";
            // 
            // subTotalLbl
            // 
            this.subTotalLbl.AutoSize = true;
            this.subTotalLbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.subTotalLbl.Location = new System.Drawing.Point(136, 116);
            this.subTotalLbl.Name = "subTotalLbl";
            this.subTotalLbl.Size = new System.Drawing.Size(62, 17);
            this.subTotalLbl.TabIndex = 5;
            this.subTotalLbl.Text = "SubTotal";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.costLabel.Location = new System.Drawing.Point(164, 33);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(34, 17);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "cost";
            // 
            // GrandTotalTxtBx
            // 
            this.GrandTotalTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.GrandTotalTxtBx.Location = new System.Drawing.Point(208, 183);
            this.GrandTotalTxtBx.Name = "GrandTotalTxtBx";
            this.GrandTotalTxtBx.ReadOnly = true;
            this.GrandTotalTxtBx.Size = new System.Drawing.Size(142, 20);
            this.GrandTotalTxtBx.TabIndex = 3;
            this.GrandTotalTxtBx.TextChanged += new System.EventHandler(this.GrandTotalTxtBx_TextChanged);
            // 
            // SalesTaxTextBx
            // 
            this.SalesTaxTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SalesTaxTextBx.Location = new System.Drawing.Point(208, 148);
            this.SalesTaxTextBx.Name = "SalesTaxTextBx";
            this.SalesTaxTextBx.ReadOnly = true;
            this.SalesTaxTextBx.Size = new System.Drawing.Size(142, 20);
            this.SalesTaxTextBx.TabIndex = 2;
            this.SalesTaxTextBx.TextChanged += new System.EventHandler(this.SalesTaxTextBx_TextChanged);
            // 
            // SubTotalTxtBx
            // 
            this.SubTotalTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SubTotalTxtBx.Location = new System.Drawing.Point(208, 113);
            this.SubTotalTxtBx.Name = "SubTotalTxtBx";
            this.SubTotalTxtBx.ReadOnly = true;
            this.SubTotalTxtBx.Size = new System.Drawing.Size(142, 20);
            this.SubTotalTxtBx.TabIndex = 1;
            this.SubTotalTxtBx.TextChanged += new System.EventHandler(this.SubTotalTxtBx_TextChanged);
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.costTextBox.Location = new System.Drawing.Point(208, 30);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(142, 20);
            this.costTextBox.TabIndex = 0;
            this.costTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 394);
            this.ControlBox = false;
            this.Controls.Add(this.OrderGroupBoxAtOrderForm);
            this.Controls.Add(this.MovieSelectedGroupBoxAtOrderForm);
            this.Controls.Add(this.StreamButtonAtOrderForm);
            this.Controls.Add(this.CancelbuttonAtOrderForm);
            this.Controls.Add(this.backButtonAtOrderForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MovieSelectedGroupBoxAtOrderForm.ResumeLayout(false);
            this.MovieSelectedGroupBoxAtOrderForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).EndInit();
            this.OrderGroupBoxAtOrderForm.ResumeLayout(false);
            this.OrderGroupBoxAtOrderForm.PerformLayout();
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
        private System.Windows.Forms.GroupBox OrderGroupBoxAtOrderForm;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox GrandTotalTxtBx;
        private System.Windows.Forms.TextBox SalesTaxTextBx;
        private System.Windows.Forms.Label GrandTotalLbl;
        private System.Windows.Forms.Label SalesTaxLbl;
        private System.Windows.Forms.Label subTotalLbl;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox hiddenTxtBx;
        private System.Windows.Forms.Label hiddenLabel;
        private System.Windows.Forms.CheckBox OrderDVDCkBx;
        public System.Windows.Forms.TextBox TitleTextBox;
        public System.Windows.Forms.TextBox CategoryTextBox;
        public System.Windows.Forms.PictureBox MoviePic;
        public System.Windows.Forms.TextBox costTextBox;
        public System.Windows.Forms.TextBox SubTotalTxtBx;
    }
}