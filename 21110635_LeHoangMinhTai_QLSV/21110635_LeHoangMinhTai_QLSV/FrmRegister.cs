using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110635_LeHoangMinhTai_QLSV
{
    public partial class FrmRegister : Form
    {
        MY_DB db = new MY_DB();
        int time = 60;
        string randomCode;
        public static string to;
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MY_DB myDB = new MY_DB();
            SqlCommand cmd = new SqlCommand("Insert into Log_in (username, password, email) values (@us, @pass, @email)", myDB.getConnection);
            cmd.Parameters.Add("@us", SqlDbType.Char).Value = txtUserName.Text;
            cmd.Parameters.Add("@pass", SqlDbType.Char).Value = txtPass.Text;
            cmd.Parameters.Add("@email", SqlDbType.NChar).Value = txtEmail.Text;

            if (checkInfor())
            {
                if (checkCode() == false)
                {
                    return;
                }
                if (txtPass.Text != txtCfmPass.Text)
                {
                    MessageBox.Show("Password authentication is wrong, please check again", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Text = "";
                    return;
                }
                myDB.openConnection();
                if (checkUserExist(txtUserName.Text.ToString().Trim()) == false)
                {
                    MessageBox.Show("This username has already existed", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account successfully created", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Text = "";
                    txtPass.Text = "";
                    txtCfmPass.Text = "";
                }
                else
                {
                    MessageBox.Show("Registration error", "Create Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myDB.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Please do not leave information blank", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            pictureBoxAddLogo.Image = Image.FromFile("../../image/hcmute.jpg");
            lblChkEmail.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            try
            {
                timerSendCode.Start();
                if (txtEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your email address", "Add Account",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra email đã tồn tại hay chưa
                if (existEmail() == true)
                {
                    MessageBox.Show("Email already used, please enter another email",
                        "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo mã ngẫu nhiên và gửi email
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();

                string to = txtEmail.Text.Trim();
                from = "21110635@student.hcmute.edu.vn"; // Email của bạn
                pass = "Nguyentam_@1984";

                messageBody = "Code: " + randomCode;

                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Account creation code";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code send successfully", "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timerSendCode.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }
        private bool checkUserExist(string usn)
        {
            try
            {
                MY_DB db = new MY_DB();
                db.openConnection();
                SqlCommand cmd = new SqlCommand("select * from Log_in where username = @username", db.getConnection);
                cmd.Parameters.Add("@username", SqlDbType.NChar).Value = usn;
                var result = cmd.ExecuteReader();
                if(result.HasRows)
                {
                    db.closeConnection();
                    return false;
                }
                db.closeConnection();
                return true;
            }
            catch { 
                return false;
            }

        }

        private bool checkCode()
        {
            if (txtCode.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your code", "Forget Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (randomCode == txtCode.Text.ToString())
            {
                to = txtCode.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Wrong code");
                return false;
            }
        }
        private bool existEmail()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Log_in where email = '" + txtEmail.Text.Trim() + "'", db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                if (tb.Rows.Count > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message, "Add account",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool checkInfor()
        {
            if (txtUserName.Text.Trim() == "" || txtPass.Text.Trim() == "" || txtCfmPass.Text.Trim() == "" || txtCode.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void timerSendCode_Tick(object sender, EventArgs e)
        {
            time--;
            
                if (time >= 0)
                {
                    btnSendCode.Enabled = false;
                    lblChkEmail.Text = "Resend code in " + time + "second";
                }
                else
                {
                    lblChkEmail.Text = "";
                    btnSendCode.Enabled = true;
                    timerSendCode.Enabled = false;
                }
            
            
        }
    }
}
