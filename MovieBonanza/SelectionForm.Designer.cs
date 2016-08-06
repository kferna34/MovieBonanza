namespace MovieBonanza
{
    partial class SelectionForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MovieDropdownList = new System.Windows.Forms.ListBox();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nextButtonAtSelectionForm = new System.Windows.Forms.Button();
            this.pictureOfMovie = new System.Windows.Forms.PictureBox();
            this.SelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(13, 13);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(630, 25);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Please Choose the movie you want to STREAM from the list below";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(14, 53);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(135, 23);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Current Movies";
            // 
            // MovieDropdownList
            // 
            this.MovieDropdownList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieDropdownList.FormattingEnabled = true;
            this.MovieDropdownList.ItemHeight = 19;
            this.MovieDropdownList.Items.AddRange(new object[] {
            "Cedar Rapids\t\t\t",
            "Company Men\t\t\t",
            "Death Race 2\t\t\t",
            "Footloose\t\t\t\t",
            "Gnomeo and Juliet\t\t\t",
            "I am Number Four\t\t\t",
            "Just Go With It\t\t\t",
            "Movies\t\t\t\t",
            "No strings Attached\t\t\t",
            "Real Steel\t\t\t\t",
            "Sanctrum\t\t\t\t",
            "Season of the Witch\t\t\t",
            "The Dilemma\t\t\t",
            "The Eagle\t\t\t\t",
            "The Green Hornet\t\t\t",
            "The Mechanic\t\t\t",
            "The Other Woman\t\t\t",
            "The Rite\t\t\t\t",
            "The roommate\t\t\t",
            "The Way Back\t\t\t",
            "Waiting for Forever\t\t\t"});
            this.MovieDropdownList.Location = new System.Drawing.Point(18, 79);
            this.MovieDropdownList.Name = "MovieDropdownList";
            this.MovieDropdownList.Size = new System.Drawing.Size(225, 289);
            this.MovieDropdownList.Sorted = true;
            this.MovieDropdownList.TabIndex = 2;
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.Controls.Add(this.pictureOfMovie);
            this.SelectionGroupBox.Controls.Add(this.label1);
            this.SelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectionGroupBox.Controls.Add(this.titleLabel);
            this.SelectionGroupBox.Controls.Add(this.costTextBox);
            this.SelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectionGroupBox.Controls.Add(this.textBox1);
            this.SelectionGroupBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionGroupBox.Location = new System.Drawing.Point(274, 79);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(466, 171);
            this.SelectionGroupBox.TabIndex = 3;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Your Selection";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 124);
            this.textBox1.TabIndex = 0;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(185, 55);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(262, 27);
            this.TitleTextBox.TabIndex = 1;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CategoryTextBox.Location = new System.Drawing.Point(185, 111);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(123, 27);
            this.CategoryTextBox.TabIndex = 2;
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.costTextBox.Location = new System.Drawing.Point(337, 111);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(110, 27);
            this.costTextBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.titleLabel.Location = new System.Drawing.Point(181, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(45, 23);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.CategoryLabel.Location = new System.Drawing.Point(181, 85);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(84, 23);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(370, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cost";
            // 
            // nextButtonAtSelectionForm
            // 
            this.nextButtonAtSelectionForm.Enabled = false;
            this.nextButtonAtSelectionForm.Location = new System.Drawing.Point(637, 329);
            this.nextButtonAtSelectionForm.Name = "nextButtonAtSelectionForm";
            this.nextButtonAtSelectionForm.Size = new System.Drawing.Size(123, 28);
            this.nextButtonAtSelectionForm.TabIndex = 4;
            this.nextButtonAtSelectionForm.Text = "Next";
            this.nextButtonAtSelectionForm.UseVisualStyleBackColor = true;
            this.nextButtonAtSelectionForm.Click += new System.EventHandler(this.nextButtonAtSelectionForm_Click);
            // 
            // pictureOfMovie
            // 
            this.pictureOfMovie.Location = new System.Drawing.Point(15, 32);
            this.pictureOfMovie.Name = "pictureOfMovie";
            this.pictureOfMovie.Size = new System.Drawing.Size(151, 117);
            this.pictureOfMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureOfMovie.TabIndex = 7;
            this.pictureOfMovie.TabStop = false;
            this.pictureOfMovie.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 394);
            this.ControlBox = false;
            this.Controls.Add(this.nextButtonAtSelectionForm);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.MovieDropdownList);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.SelectionGroupBox.ResumeLayout(false);
            this.SelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ListBox MovieDropdownList;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.PictureBox pictureOfMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nextButtonAtSelectionForm;
    }
}

