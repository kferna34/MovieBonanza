namespace MovieBonanza
{
    partial class StreamForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.ThankYoulabel = new System.Windows.Forms.Label();
            this.creditcardBilledLabel = new System.Windows.Forms.Label();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.movieStartsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(660, 332);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ThankYoulabel
            // 
            this.ThankYoulabel.AutoSize = true;
            this.ThankYoulabel.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYoulabel.Location = new System.Drawing.Point(25, 58);
            this.ThankYoulabel.Name = "ThankYoulabel";
            this.ThankYoulabel.Size = new System.Drawing.Size(724, 40);
            this.ThankYoulabel.TabIndex = 1;
            this.ThankYoulabel.Text = "Thank you for choosing Movie Bonanza!";
            // 
            // creditcardBilledLabel
            // 
            this.creditcardBilledLabel.AutoSize = true;
            this.creditcardBilledLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.creditcardBilledLabel.Location = new System.Drawing.Point(231, 129);
            this.creditcardBilledLabel.Name = "creditcardBilledLabel";
            this.creditcardBilledLabel.Size = new System.Drawing.Size(0, 23);
            this.creditcardBilledLabel.TabIndex = 2;
            this.creditcardBilledLabel.Click += new System.EventHandler(this.creditcardBilledLabel_Click);
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(86, 98);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(0, 13);
            this.selectionLabel.TabIndex = 3;
            // 
            // movieStartsLabel
            // 
            this.movieStartsLabel.AutoSize = true;
            this.movieStartsLabel.Location = new System.Drawing.Point(89, 114);
            this.movieStartsLabel.Name = "movieStartsLabel";
            this.movieStartsLabel.Size = new System.Drawing.Size(0, 13);
            this.movieStartsLabel.TabIndex = 4;
            this.movieStartsLabel.Click += new System.EventHandler(this.movieStartsLabel_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 394);
            this.Controls.Add(this.movieStartsLabel);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.creditcardBilledLabel);
            this.Controls.Add(this.ThankYoulabel);
            this.Controls.Add(this.OKButton);
            this.Name = "StreamForm";
            this.Text = "StreamForm";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ThankYoulabel;
        private System.Windows.Forms.Label creditcardBilledLabel;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Label movieStartsLabel;
    }
}