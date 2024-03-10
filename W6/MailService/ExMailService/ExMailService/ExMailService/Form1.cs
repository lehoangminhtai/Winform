using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using OtpNet;
using System.Windows.Forms;

namespace ExMailService
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                
                string receiveMail = txtEmail.Text.Trim();
                OTP.Email = receiveMail;
                OTP.SendEmail(receiveMail);
               
                this.DialogResult = DialogResult.OK;
               
                
            }
            catch {
                MessageBox.Show("Register fail!!");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
