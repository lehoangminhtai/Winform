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
    public partial class _21110635_Bai6 : Form
    {
        public _21110635_Bai6()
        {
            InitializeComponent();
        }

        private void _21110635_Bai6_Load(object sender, EventArgs e)
        {
            // tạo chuỗi chứa kết nối đên db
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            // tạo kết nối
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand();
            try
            {
                // mở kết nối
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from Employees";
                richTextBox1.Text = "Connection opened" +
                "\n Kết nối lệnh với Connection hiện hữu:" +
                "\n \t " + cmd.CommandText ;
            }
            catch (SqlException ex)
            {
                // báo lỗi
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //đóng kết nối conn.Close();
                label1.Text = "Connection closed";
            }
        }
    }
}
