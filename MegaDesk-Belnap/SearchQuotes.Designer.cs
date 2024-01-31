namespace MegaDesk_Belnap
{
    partial class SearchQuotes
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
            this.SearchQuotesCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchQuotesCloseButton
            // 
            this.SearchQuotesCloseButton.Location = new System.Drawing.Point(650, 381);
            this.SearchQuotesCloseButton.Name = "SearchQuotesCloseButton";
            this.SearchQuotesCloseButton.Size = new System.Drawing.Size(102, 37);
            this.SearchQuotesCloseButton.TabIndex = 0;
            this.SearchQuotesCloseButton.Text = "&Close";
            this.SearchQuotesCloseButton.UseVisualStyleBackColor = true;
            this.SearchQuotesCloseButton.Click += new System.EventHandler(this.SearchQuotesCloseButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchQuotesCloseButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchQuotesCloseButton;
    }
}