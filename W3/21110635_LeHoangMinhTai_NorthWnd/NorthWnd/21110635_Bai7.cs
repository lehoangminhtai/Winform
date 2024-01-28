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

namespace NorthWnd
{
    public partial class _21110635_Bai7 : Form
    {
        public _21110635_Bai7()
        {
            InitializeComponent();
        }

        private void _21110635_Bai7_Load(object sender, EventArgs e)
        {
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            string strSQL = @"select count(*) from Employees";
            // tạo kết nối
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSQL,conn);
            label1.Text = "Command được tạo và kết nối";
            try
            {
                // mở kết nối
                conn.Open();
            
                cmd.CommandText = @"select count(*) from Employees";
                label2.Text = "Connection opened" +
                "\n Kết quả số lượng nv:" +
                "\n \t " + cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                // báo lỗi
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //đóng kết nối conn.Close();
                label3.Text = "Connection closed";
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
