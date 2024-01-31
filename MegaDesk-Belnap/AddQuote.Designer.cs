namespace MegaDesk_Belnap
{
    partial class AddQuotes
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.Label();
            this.DeskWidth = new System.Windows.Forms.Label();
            this.DeskDepth = new System.Windows.Forms.Label();
            this.DesktopMaterial = new System.Windows.Forms.Label();
            this.numOfDrawers = new System.Windows.Forms.Label();
            this.RushOrder = new System.Windows.Forms.Label();
            this.CustomerInputBox = new System.Windows.Forms.TextBox();
            this.DeskWidthInputBox = new System.Windows.Forms.TextBox();
            this.DeskDepthInputBox = new System.Windows.Forms.TextBox();
            this.threeDayRush = new System.Windows.Forms.RadioButton();
            this.fiveDayRush = new System.Windows.Forms.RadioButton();
            this.sevenDayRush = new System.Windows.Forms.RadioButton();
            this.noRush = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(633, 378);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(110, 45);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(100, 75);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(173, 30);
            this.CustomerName.TabIndex = 1;
            this.CustomerName.Text = "Customer Name";
            // 
            // DeskWidth
            // 
            this.DeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(100, 115);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(202, 29);
            this.DeskWidth.TabIndex = 2;
            this.DeskWidth.Text = "Width (in inches)";
            // 
            // DeskDepth
            // 
            this.DeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(100, 157);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(173, 29);
            this.DeskDepth.TabIndex = 3;
            this.DeskDepth.Text = "Depth (in inches)";
            // 
            // DesktopMaterial
            // 
            this.DesktopMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopMaterial.Location = new System.Drawing.Point(100, 244);
            this.DesktopMaterial.Name = "DesktopMaterial";
            this.DesktopMaterial.Size = new System.Drawing.Size(169, 32);
            this.DesktopMaterial.TabIndex = 4;
            this.DesktopMaterial.Text = "Desktop Material";
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawers.Location = new System.Drawing.Point(100, 203);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(187, 32);
            this.numOfDrawers.TabIndex = 5;
            this.numOfDrawers.Text = "Number of Drawers";
            // 
            // RushOrder
            // 
            this.RushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrder.Location = new System.Drawing.Point(100, 342);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(187, 32);
            this.RushOrder.TabIndex = 6;
            this.RushOrder.Text = "Rush Order";
            // 
            // CustomerInputBox
            // 
            this.CustomerInputBox.Location = new System.Drawing.Point(336, 77);
            this.CustomerInputBox.Name = "CustomerInputBox";
            this.CustomerInputBox.Size = new System.Drawing.Size(228, 22);
            this.CustomerInputBox.TabIndex = 7;
            this.CustomerInputBox.TextChanged += new System.EventHandler(this.CustomerInputBox_TextChanged);
            // 
            // DeskWidthInputBox
            // 
            this.DeskWidthInputBox.Location = new System.Drawing.Point(336, 117);
            this.DeskWidthInputBox.Name = "DeskWidthInputBox";
            this.DeskWidthInputBox.Size = new System.Drawing.Size(100, 22);
            this.DeskWidthInputBox.TabIndex = 8;
            // 
            // DeskDepthInputBox
            // 
            this.DeskDepthInputBox.Location = new System.Drawing.Point(336, 159);
            this.DeskDepthInputBox.Name = "DeskDepthInputBox";
            this.DeskDepthInputBox.Size = new System.Drawing.Size(100, 22);
            this.DeskDepthInputBox.TabIndex = 9;
            // 
            // threeDayRush
            // 
            this.threeDayRush.AutoSize = true;
            this.threeDayRush.Location = new System.Drawing.Point(336, 342);
            this.threeDayRush.Name = "threeDayRush";
            this.threeDayRush.Size = new System.Drawing.Size(97, 20);
            this.threeDayRush.TabIndex = 10;
            this.threeDayRush.TabStop = true;
            this.threeDayRush.Text = "3 Day Rush";
            this.threeDayRush.UseVisualStyleBackColor = true;
            // 
            // fiveDayRush
            // 
            this.fiveDayRush.AutoSize = true;
            this.fiveDayRush.Location = new System.Drawing.Point(336, 368);
            this.fiveDayRush.Name = "fiveDayRush";
            this.fiveDayRush.Size = new System.Drawing.Size(97, 20);
            this.fiveDayRush.TabIndex = 11;
            this.fiveDayRush.TabStop = true;
            this.fiveDayRush.Text = "5 Day Rush";
            this.fiveDayRush.UseVisualStyleBackColor = true;
            // 
            // sevenDayRush
            // 
            this.sevenDayRush.AutoSize = true;
            this.sevenDayRush.Location = new System.Drawing.Point(336, 394);
            this.sevenDayRush.Name = "sevenDayRush";
            this.sevenDayRush.Size = new System.Drawing.Size(97, 20);
            this.sevenDayRush.TabIndex = 12;
            this.sevenDayRush.TabStop = true;
            this.sevenDayRush.Text = "7 Day Rush";
            this.sevenDayRush.UseVisualStyleBackColor = true;
            // 
            // noRush
            // 
            this.noRush.AutoSize = true;
            this.noRush.Location = new System.Drawing.Point(336, 420);
            this.noRush.Name = "noRush";
            this.noRush.Size = new System.Drawing.Size(179, 20);
            this.noRush.TabIndex = 13;
            this.noRush.TabStop = true;
            this.noRush.Text = "None (Standard 14 Days)";
            this.noRush.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.listBox1.Location = new System.Drawing.Point(336, 244);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 68);
            this.listBox1.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(336, 206);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "All fields must be completed:";
            // 
            // AddQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.noRush);
            this.Controls.Add(this.sevenDayRush);
            this.Controls.Add(this.fiveDayRush);
            this.Controls.Add(this.threeDayRush);
            this.Controls.Add(this.DeskDepthInputBox);
            this.Controls.Add(this.DeskWidthInputBox);
            this.Controls.Add(this.CustomerInputBox);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.DesktopMaterial);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.SubmitButton);
            this.Name = "AddQuotes";
            this.Text = "Add Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label DeskWidth;
        private System.Windows.Forms.Label DeskDepth;
        private System.Windows.Forms.Label DesktopMaterial;
        private System.Windows.Forms.Label numOfDrawers;
        private System.Windows.Forms.Label RushOrder;
        private System.Windows.Forms.TextBox CustomerInputBox;
        private System.Windows.Forms.TextBox DeskWidthInputBox;
        private System.Windows.Forms.TextBox DeskDepthInputBox;
        private System.Windows.Forms.RadioButton threeDayRush;
        private System.Windows.Forms.RadioButton fiveDayRush;
        private System.Windows.Forms.RadioButton sevenDayRush;
        private System.Windows.Forms.RadioButton noRush;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}