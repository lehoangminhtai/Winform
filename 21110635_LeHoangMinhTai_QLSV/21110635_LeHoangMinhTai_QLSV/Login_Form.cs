using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _21110635_LeHoangMinhTai_QLSV
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../image/hcmute.jpg");
        }

        private void btt_Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @User AND password = @Pass", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                //MessageBox.Show("Ok, next time will be go to Main Menu of App");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                MY_DB mydb = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                mydb.openConnection();
                SqlCommand command = new SqlCommand("INSERT INTO log_in VALUES (@username,@password)", mydb.getConnection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                adapter.SelectCommand = command;

                int rowsAffected = command.ExecuteNonQuery();

                // Kiểm tra xem có bao nhiêu dòng đã được thêm vào cơ sở dữ liệu
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể thêm dữ liệu!");
                }
                mydb.closeConnection();
            }
            catch
            {
                MessageBox.Show("User tồn tại!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            // Đóng kết nối sau khi hoàn tất công việc với cơ sở dữ liệu
            
           

        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister resgister = new FrmRegister();
            resgister.ShowDialog();
        }
    }
}
