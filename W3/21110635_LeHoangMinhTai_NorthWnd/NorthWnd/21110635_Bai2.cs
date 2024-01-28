using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWnd
{
    public partial class _21110635_Bai2 : Form
    {
        public _21110635_Bai2()
        {
            InitializeComponent();
        }

        private void _21110635_Bai2_Load(object sender, EventArgs e)
        {
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            // tạo kết nối
            SqlConnection conn = new SqlConnection(strCon);
            //tạo command

            SqlCommand cmd = new SqlCommand();
            label3.Text = "Command created";
            try
            {
                // mở kết nối
                conn.Open();
                label1.Text = "Connection opened";
                cmd.Connection = conn;
                label4.Text = "Ket Noi lenh voi Connection hiện tại";
            }
            catch (SqlException ex)
            {
                // báo lỗi
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //đóng kết nối conn.Close();
                label2.Text = "Connection closed";
            }
        }
    }
}
