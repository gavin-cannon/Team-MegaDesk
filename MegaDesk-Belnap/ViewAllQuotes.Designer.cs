namespace MegaDesk_Belnap
{
    partial class ViewAllQuotes
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
            this.ViewAllQuotesCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewAllQuotesCloseButton
            // 
            this.ViewAllQuotesCloseButton.Location = new System.Drawing.Point(613, 373);
            this.ViewAllQuotesCloseButton.Name = "ViewAllQuotesCloseButton";
            this.ViewAllQuotesCloseButton.Size = new System.Drawing.Size(141, 38);
            this.ViewAllQuotesCloseButton.TabIndex = 0;
            this.ViewAllQuotesCloseButton.Text = "Close";
            this.ViewAllQuotesCloseButton.UseVisualStyleBackColor = true;
            this.ViewAllQuotesCloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewAllQuotesCloseButton);
            this.Name = "ViewAllQuotes";
            this.Text = "View Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewAllQuotesCloseButton;
    }
}