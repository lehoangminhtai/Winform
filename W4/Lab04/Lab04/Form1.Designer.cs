namespace Lab04
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.chkWhitening = new System.Windows.Forms.CheckBox();
            this.lblWhiteningCost = new System.Windows.Forms.Label();
            this.chkXRay = new System.Windows.Forms.CheckBox();
            this.lblXRayCost = new System.Windows.Forms.Label();
            this.lblFilling = new System.Windows.Forms.Label();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.lblFillCost = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(120, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dental Payment form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên Khách Hàng";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(249, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 26);
            this.txtName.TabIndex = 2;
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Location = new System.Drawing.Point(72, 150);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(91, 24);
            this.chkClean.TabIndex = 3;
            this.chkClean.Text = "Cạo Vôi";
            this.chkClean.UseVisualStyleBackColor = true;
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Location = new System.Drawing.Point(445, 152);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(72, 20);
            this.lblCleanCost.TabIndex = 4;
            this.lblCleanCost.Text = "$100000";
            // 
            // chkWhitening
            // 
            this.chkWhitening.AutoSize = true;
            this.chkWhitening.Location = new System.Drawing.Point(72, 194);
            this.chkWhitening.Name = "chkWhitening";
            this.chkWhitening.Size = new System.Drawing.Size(105, 24);
            this.chkWhitening.TabIndex = 3;
            this.chkWhitening.Text = "Tẩy Trắng";
            this.chkWhitening.UseVisualStyleBackColor = true;
            // 
            // lblWhiteningCost
            // 
            this.lblWhiteningCost.AutoSize = true;
            this.lblWhiteningCost.Location = new System.Drawing.Point(436, 195);
            this.lblWhiteningCost.Name = "lblWhiteningCost";
            this.lblWhiteningCost.Size = new System.Drawing.Size(81, 20);
            this.lblWhiteningCost.TabIndex = 4;
            this.lblWhiteningCost.Text = "$1200000";
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Location = new System.Drawing.Point(72, 240);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(153, 24);
            this.chkXRay.TabIndex = 3;
            this.chkXRay.Text = "Chụp Hình Răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            // 
            // lblXRayCost
            // 
            this.lblXRayCost.AutoSize = true;
            this.lblXRayCost.Location = new System.Drawing.Point(445, 242);
            this.lblXRayCost.Name = "lblXRayCost";
            this.lblXRayCost.Size = new System.Drawing.Size(72, 20);
            this.lblXRayCost.TabIndex = 4;
            this.lblXRayCost.Text = "$200000";
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Location = new System.Drawing.Point(72, 311);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(88, 20);
            this.lblFilling.TabIndex = 5;
            this.lblFilling.Text = "Trám Răng";
            // 
            // numFilling
            // 
            this.numFilling.Location = new System.Drawing.Point(167, 308);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(108, 26);
            this.numFilling.TabIndex = 6;
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Location = new System.Drawing.Point(430, 311);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(87, 20);
            this.lblFillCost.TabIndex = 7;
            this.lblFillCost.Text = "$80000/cái";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(231, 408);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(336, 408);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(160, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(72, 500);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(405, 500);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(91, 35);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Tính Tiền";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(31, 564);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(486, 104);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 687);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFillCost);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.lblFilling);
            this.Controls.Add(this.lblXRayCost);
            this.Controls.Add(this.lblWhiteningCost);
            this.Controls.Add(this.lblCleanCost);
            this.Controls.Add(this.chkXRay);
            this.Controls.Add(this.chkWhitening);
            this.Controls.Add(this.chkClean);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkClean;
        private System.Windows.Forms.Label lblCleanCost;
        private System.Windows.Forms.CheckBox chkWhitening;
        private System.Windows.Forms.Label lblWhiteningCost;
        private System.Windows.Forms.CheckBox chkXRay;
        private System.Windows.Forms.Label lblXRayCost;
        private System.Windows.Forms.Label lblFilling;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.Label lblFillCost;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox listBox1;
    }
}

