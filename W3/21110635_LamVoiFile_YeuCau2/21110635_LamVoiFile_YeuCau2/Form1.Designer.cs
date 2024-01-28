namespace _21110635_LamVoiFile_YeuCau2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbt = new System.Windows.Forms.RadioButton();
            this.rbt_CreateDic = new System.Windows.Forms.RadioButton();
            this.rtShow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hiển thị";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lựa Chọn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdbt
            // 
            this.rdbt.AutoSize = true;
            this.rdbt.Location = new System.Drawing.Point(61, 118);
            this.rdbt.Name = "rdbt";
            this.rdbt.Size = new System.Drawing.Size(129, 24);
            this.rdbt.TabIndex = 5;
            this.rdbt.TabStop = true;
            this.rdbt.Text = "Thông tin File";
            this.rdbt.UseVisualStyleBackColor = true;
            this.rdbt.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbt_CreateDic
            // 
            this.rbt_CreateDic.AutoSize = true;
            this.rbt_CreateDic.Location = new System.Drawing.Point(61, 186);
            this.rbt_CreateDic.Name = "rbt_CreateDic";
            this.rbt_CreateDic.Size = new System.Drawing.Size(122, 24);
            this.rbt_CreateDic.TabIndex = 6;
            this.rbt_CreateDic.TabStop = true;
            this.rbt_CreateDic.Text = "Tạo thư mục";
            this.rbt_CreateDic.UseVisualStyleBackColor = true;
            this.rbt_CreateDic.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rtShow
            // 
            this.rtShow.Location = new System.Drawing.Point(231, 26);
            this.rtShow.Name = "rtShow";
            this.rtShow.Size = new System.Drawing.Size(523, 329);
            this.rtShow.TabIndex = 7;
            this.rtShow.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtShow);
            this.Controls.Add(this.rbt_CreateDic);
            this.Controls.Add(this.rdbt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "21110635_Frm_LamVoiFile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbt;
        private System.Windows.Forms.RadioButton rbt_CreateDic;
        private System.Windows.Forms.RichTextBox rtShow;
    }
}

