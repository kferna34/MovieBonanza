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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.HeaderLabel.Location = new System.Drawing.Point(14, 63);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(135, 23);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Current Movies";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
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
            this.listBox1.Location = new System.Drawing.Point(18, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 289);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 2;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 394);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "SelectionForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

