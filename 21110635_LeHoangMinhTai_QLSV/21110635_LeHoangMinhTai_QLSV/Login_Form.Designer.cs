namespace _21110635_LeHoangMinhTai_QLSV
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            this.btt_Cancel = new System.Windows.Forms.Button();
            this.btt_Login = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btt_Cancel
            // 
            this.btt_Cancel.BackColor = System.Drawing.Color.Snow;
            this.btt_Cancel.Location = new System.Drawing.Point(525, 390);
            this.btt_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_Cancel.Name = "btt_Cancel";
            this.btt_Cancel.Size = new System.Drawing.Size(112, 35);
            this.btt_Cancel.TabIndex = 14;
            this.btt_Cancel.Text = "Cancel";
            this.btt_Cancel.UseVisualStyleBackColor = false;
            this.btt_Cancel.Click += new System.EventHandler(this.btt_Cancel_Click);
            // 
            // btt_Login
            // 
            this.btt_Login.BackColor = System.Drawing.Color.Snow;
            this.btt_Login.Location = new System.Drawing.Point(237, 390);
            this.btt_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_Login.Name = "btt_Login";
            this.btt_Login.Size = new System.Drawing.Size(112, 35);
            this.btt_Login.TabIndex = 13;
            this.btt_Login.Text = "Login";
            this.btt_Login.UseVisualStyleBackColor = false;
            this.btt_Login.Click += new System.EventHandler(this.btt_Login_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(377, 282);
            this.TextBoxPassword.Multiline = true;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(260, 41);
            this.TextBoxPassword.TabIndex = 11;
            this.toolTip1.SetToolTip(this.TextBoxPassword, "Nhap pass");
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // TextBoxUsername
            // 
            this.errorProvider1.SetError(this.TextBoxUsername, "Please enter username!!");
            this.TextBoxUsername.Location = new System.Drawing.Point(377, 188);
            this.TextBoxUsername.Multiline = true;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(260, 35);
            this.TextBoxUsername.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(163, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogin.Location = new System.Drawing.Point(367, 63);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(119, 38);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(163, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "User name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(182, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(233, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Don\'t have account?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Location = new System.Drawing.Point(407, 465);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(69, 20);
            this.linkLabelRegister.TabIndex = 17;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Register";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(500, 338);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 20);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_Cancel);
            this.Controls.Add(this.btt_Login);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login_Form";
            this.Text = "21110635_Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_Cancel;
        private System.Windows.Forms.Button btt_Login;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}