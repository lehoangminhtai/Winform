namespace _21110635_Lê_Hoàng_Minh_Tài_ComplexNumber
{
    partial class Form1
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
            this.imaginaryTextBox = new System.Windows.Forms.TextBox();
            this.realTextBox = new System.Windows.Forms.TextBox();
            this.imaginaryLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.realLabel = new System.Windows.Forms.Label();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imaginaryTextBox
            // 
            this.imaginaryTextBox.Location = new System.Drawing.Point(240, 141);
            this.imaginaryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imaginaryTextBox.Name = "imaginaryTextBox";
            this.imaginaryTextBox.Size = new System.Drawing.Size(195, 26);
            this.imaginaryTextBox.TabIndex = 11;
            // 
            // realTextBox
            // 
            this.realTextBox.Location = new System.Drawing.Point(240, 48);
            this.realTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.realTextBox.Name = "realTextBox";
            this.realTextBox.Size = new System.Drawing.Size(195, 26);
            this.realTextBox.TabIndex = 12;
            // 
            // imaginaryLabel
            // 
            this.imaginaryLabel.AutoSize = true;
            this.imaginaryLabel.Location = new System.Drawing.Point(95, 148);
            this.imaginaryLabel.Name = "imaginaryLabel";
            this.imaginaryLabel.Size = new System.Drawing.Size(78, 20);
            this.imaginaryLabel.TabIndex = 8;
            this.imaginaryLabel.Text = "Imaginary";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(95, 476);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 20);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Notice";
            // 
            // realLabel
            // 
            this.realLabel.AutoSize = true;
            this.realLabel.Location = new System.Drawing.Point(95, 57);
            this.realLabel.Name = "realLabel";
            this.realLabel.Size = new System.Drawing.Size(42, 20);
            this.realLabel.TabIndex = 10;
            this.realLabel.Text = "Real";
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(508, 349);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(124, 39);
            this.MultiplyButton.TabIndex = 3;
            this.MultiplyButton.Text = "Multify";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click_1);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(302, 349);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(124, 39);
            this.subtractButton.TabIndex = 4;
            this.subtractButton.Text = "Substract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(98, 349);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 39);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(582, 136);
            this.secondButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(124, 39);
            this.secondButton.TabIndex = 6;
            this.secondButton.Text = "Set No 2";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click_1);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(582, 43);
            this.firstButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(124, 39);
            this.firstButton.TabIndex = 7;
            this.firstButton.Text = "Set No 1";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.imaginaryTextBox);
            this.Controls.Add(this.realTextBox);
            this.Controls.Add(this.imaginaryLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.realLabel);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Name = "Form1";
            this.Text = "ComplexNumber_21110635";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imaginaryTextBox;
        private System.Windows.Forms.TextBox realTextBox;
        private System.Windows.Forms.Label imaginaryLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label realLabel;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button firstButton;
    }
}

