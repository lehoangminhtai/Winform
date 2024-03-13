namespace _21110635_LeHoangMinhTai_QLSV
{
    partial class StaticsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.lblPercentMale = new System.Windows.Forms.Label();
            this.lblPercentFemale = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statics ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(-7, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Student:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(212, 105);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 38);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            this.lblTotal.MouseEnter += new System.EventHandler(this.lblTotal_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelFemale);
            this.groupBox1.Controls.Add(this.panelMale);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Male";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Female";
            // 
            // panelMale
            // 
            this.panelMale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMale.Controls.Add(this.lblPercentMale);
            this.panelMale.Location = new System.Drawing.Point(23, 86);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(249, 155);
            this.panelMale.TabIndex = 1;
            this.panelMale.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panelFemale
            // 
            this.panelFemale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFemale.Controls.Add(this.lblPercentFemale);
            this.panelFemale.Location = new System.Drawing.Point(446, 86);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(249, 155);
            this.panelFemale.TabIndex = 2;
            // 
            // lblPercentMale
            // 
            this.lblPercentMale.AutoSize = true;
            this.lblPercentMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentMale.Location = new System.Drawing.Point(60, 69);
            this.lblPercentMale.Name = "lblPercentMale";
            this.lblPercentMale.Size = new System.Drawing.Size(64, 25);
            this.lblPercentMale.TabIndex = 0;
            this.lblPercentMale.Text = "label6";
            this.lblPercentMale.MouseEnter += new System.EventHandler(this.lblPercentMale_MouseEnter);
            // 
            // lblPercentFemale
            // 
            this.lblPercentFemale.AutoSize = true;
            this.lblPercentFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentFemale.Location = new System.Drawing.Point(48, 69);
            this.lblPercentFemale.Name = "lblPercentFemale";
            this.lblPercentFemale.Size = new System.Drawing.Size(64, 25);
            this.lblPercentFemale.TabIndex = 0;
            this.lblPercentFemale.Text = "label6";
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(768, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelMale.ResumeLayout(false);
            this.panelMale.PerformLayout();
            this.panelFemale.ResumeLayout(false);
            this.panelFemale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Label lblPercentFemale;
        private System.Windows.Forms.Label lblPercentMale;
    }
}