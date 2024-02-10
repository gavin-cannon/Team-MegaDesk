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
            this.DesktopMaterialLabel = new System.Windows.Forms.Label();
            this.numOfDrawers = new System.Windows.Forms.Label();
            this.RushOrder = new System.Windows.Forms.Label();
            this.CustomerInputBox = new System.Windows.Forms.TextBox();
            this.DeskWidthInputBox = new System.Windows.Forms.TextBox();
            this.DeskDepthInputBox = new System.Windows.Forms.TextBox();
            this.DrawersInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.ComboBox();
            this.rushDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(475, 307);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(82, 37);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(75, 61);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(130, 24);
            this.CustomerName.TabIndex = 1;
            this.CustomerName.Text = "Customer Name";
            // 
            // DeskWidth
            // 
            this.DeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(75, 93);
            this.DeskWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(152, 24);
            this.DeskWidth.TabIndex = 2;
            this.DeskWidth.Text = "Width (in inches)";
            // 
            // DeskDepth
            // 
            this.DeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(75, 128);
            this.DeskDepth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(130, 24);
            this.DeskDepth.TabIndex = 3;
            this.DeskDepth.Text = "Depth (in inches)";
            // 
            // DesktopMaterialLabel
            // 
            this.DesktopMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopMaterialLabel.Location = new System.Drawing.Point(75, 198);
            this.DesktopMaterialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DesktopMaterialLabel.Name = "DesktopMaterialLabel";
            this.DesktopMaterialLabel.Size = new System.Drawing.Size(127, 26);
            this.DesktopMaterialLabel.TabIndex = 4;
            this.DesktopMaterialLabel.Text = "Desktop Material";
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawers.Location = new System.Drawing.Point(75, 165);
            this.numOfDrawers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(140, 26);
            this.numOfDrawers.TabIndex = 5;
            this.numOfDrawers.Text = "Number of Drawers";
            // 
            // RushOrder
            // 
            this.RushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrder.Location = new System.Drawing.Point(77, 234);
            this.RushOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(140, 26);
            this.RushOrder.TabIndex = 6;
            this.RushOrder.Text = "Rush Order";
            // 
            // CustomerInputBox
            // 
            this.CustomerInputBox.Location = new System.Drawing.Point(252, 63);
            this.CustomerInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerInputBox.Name = "CustomerInputBox";
            this.CustomerInputBox.Size = new System.Drawing.Size(172, 20);
            this.CustomerInputBox.TabIndex = 7;
            this.CustomerInputBox.TextChanged += new System.EventHandler(this.CustomerInputBox_TextChanged);
            this.CustomerInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.customerInputBox_Validating);
            // 
            // DeskWidthInputBox
            // 
            this.DeskWidthInputBox.Location = new System.Drawing.Point(252, 95);
            this.DeskWidthInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeskWidthInputBox.Name = "DeskWidthInputBox";
            this.DeskWidthInputBox.Size = new System.Drawing.Size(76, 20);
            this.DeskWidthInputBox.TabIndex = 8;
            this.DeskWidthInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.deskWidthInputBox_Validating);
            // 
            // DeskDepthInputBox
            // 
            this.DeskDepthInputBox.Location = new System.Drawing.Point(252, 129);
            this.DeskDepthInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeskDepthInputBox.Name = "DeskDepthInputBox";
            this.DeskDepthInputBox.Size = new System.Drawing.Size(76, 20);
            this.DeskDepthInputBox.TabIndex = 9;
            this.DeskDepthInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.deskDepthInputBox_Validating);
            // 
            // DrawersInput
            // 
            this.DrawersInput.Location = new System.Drawing.Point(252, 167);
            this.DrawersInput.Margin = new System.Windows.Forms.Padding(2);
            this.DrawersInput.Name = "DrawersInput";
            this.DrawersInput.Size = new System.Drawing.Size(90, 20);
            this.DrawersInput.TabIndex = 15;
            this.DrawersInput.Validating += new System.ComponentModel.CancelEventHandler(this.drawersInput_Validating);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "All fields must be completed:";
            // 
            // material
            // 
            this.material.FormattingEnabled = true;
            this.material.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.material.Location = new System.Drawing.Point(252, 198);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(121, 21);
            this.material.TabIndex = 17;
            this.material.Validating += new System.ComponentModel.CancelEventHandler(this.material_Validating);
            // 
            // rushDays
            // 
            this.rushDays.FormattingEnabled = true;
            this.rushDays.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.rushDays.Location = new System.Drawing.Point(252, 235);
            this.rushDays.Name = "rushDays";
            this.rushDays.Size = new System.Drawing.Size(121, 21);
            this.rushDays.TabIndex = 18;
            this.rushDays.Validating += new System.ComponentModel.CancelEventHandler(this.rushDays_Validating);
            // 
            // AddQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 392);
            this.Controls.Add(this.rushDays);
            this.Controls.Add(this.material);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawersInput);
            this.Controls.Add(this.DeskDepthInputBox);
            this.Controls.Add(this.DeskWidthInputBox);
            this.Controls.Add(this.CustomerInputBox);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.DesktopMaterialLabel);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.SubmitButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuotes";
            this.Text = "Add Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.DrawersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label DeskWidth;
        private System.Windows.Forms.Label DeskDepth;
        private System.Windows.Forms.Label DesktopMaterialLabel;
        private System.Windows.Forms.Label numOfDrawers;
        private System.Windows.Forms.Label RushOrder;
        private System.Windows.Forms.TextBox CustomerInputBox;
        private System.Windows.Forms.TextBox DeskWidthInputBox;
        private System.Windows.Forms.TextBox DeskDepthInputBox;
        private System.Windows.Forms.NumericUpDown DrawersInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox material;
        private System.Windows.Forms.ComboBox rushDays;
    }
}