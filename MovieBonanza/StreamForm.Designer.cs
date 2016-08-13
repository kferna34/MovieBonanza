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
            this.selectionLabel = new System.Windows.Forms.Label();
            this.CreditCardCharged = new System.Windows.Forms.Label();
            this.creditChargedOtherLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.streamingMessage = new System.Windows.Forms.Label();
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
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(86, 98);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(0, 13);
            this.selectionLabel.TabIndex = 3;
            // 
            // CreditCardCharged
            // 
            this.CreditCardCharged.AutoSize = true;
            this.CreditCardCharged.Font = new System.Drawing.Font("Tahoma", 14F);
            this.CreditCardCharged.Location = new System.Drawing.Point(496, 167);
            this.CreditCardCharged.Name = "CreditCardCharged";
            this.CreditCardCharged.Size = new System.Drawing.Size(46, 23);
            this.CreditCardCharged.TabIndex = 5;
            this.CreditCardCharged.Text = "     .";
            this.CreditCardCharged.Click += new System.EventHandler(this.CreditCardCharged_Click);
            // 
            // creditChargedOtherLabel
            // 
            this.creditChargedOtherLabel.AutoSize = true;
            this.creditChargedOtherLabel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.creditChargedOtherLabel.Location = new System.Drawing.Point(193, 167);
            this.creditChargedOtherLabel.Name = "creditChargedOtherLabel";
            this.creditChargedOtherLabel.Size = new System.Drawing.Size(288, 23);
            this.creditChargedOtherLabel.TabIndex = 7;
            this.creditChargedOtherLabel.Text = "Your Credit card will be charged:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(171, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Movie Bonanza  is loading:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // streamingMessage
            // 
            this.streamingMessage.AutoSize = true;
            this.streamingMessage.Font = new System.Drawing.Font("Tahoma", 14F);
            this.streamingMessage.Location = new System.Drawing.Point(460, 128);
            this.streamingMessage.MaximumSize = new System.Drawing.Size(300, 25);
            this.streamingMessage.MinimumSize = new System.Drawing.Size(0, 25);
            this.streamingMessage.Name = "streamingMessage";
            this.streamingMessage.Size = new System.Drawing.Size(289, 25);
            this.streamingMessage.TabIndex = 6;
            this.streamingMessage.Text = " The Movie:                                  ";
            this.streamingMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.streamingMessage.Click += new System.EventHandler(this.streamingMessage_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditChargedOtherLabel);
            this.Controls.Add(this.streamingMessage);
            this.Controls.Add(this.CreditCardCharged);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.ThankYoulabel);
            this.Controls.Add(this.OKButton);
            this.Name = "StreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ThankYoulabel;
      
        private System.Windows.Forms.Label selectionLabel;
        public System.Windows.Forms.Label CreditCardCharged;
        public System.Windows.Forms.Label creditChargedOtherLabel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label streamingMessage;
    }
}