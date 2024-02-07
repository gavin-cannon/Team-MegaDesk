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
            this.searchQuoteComboBox = new System.Windows.Forms.ComboBox();
            this.searchQuoteLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            // searchQuoteComboBox
            // 
            this.searchQuoteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchQuoteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteComboBox.FormattingEnabled = true;
            this.searchQuoteComboBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.searchQuoteComboBox.Location = new System.Drawing.Point(57, 116);
            this.searchQuoteComboBox.Name = "searchQuoteComboBox";
            this.searchQuoteComboBox.Size = new System.Drawing.Size(329, 33);
            this.searchQuoteComboBox.TabIndex = 1;
            this.searchQuoteComboBox.SelectedIndexChanged += new System.EventHandler(this.searchQuoteComboBox_SelectedIndexChanged);
            // 
            // searchQuoteLabel
            // 
            this.searchQuoteLabel.AutoSize = true;
            this.searchQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteLabel.Location = new System.Drawing.Point(54, 65);
            this.searchQuoteLabel.Name = "searchQuoteLabel";
            this.searchQuoteLabel.Size = new System.Drawing.Size(386, 25);
            this.searchQuoteLabel.TabIndex = 2;
            this.searchQuoteLabel.Text = "Select a desktop material to search by:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(59, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(490, 180);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchQuoteLabel);
            this.Controls.Add(this.searchQuoteComboBox);
            this.Controls.Add(this.SearchQuotesCloseButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchQuotesCloseButton;
        private System.Windows.Forms.ComboBox searchQuoteComboBox;
        private System.Windows.Forms.Label searchQuoteLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}