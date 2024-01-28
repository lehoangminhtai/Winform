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
    public partial class _21110635_Bai3 : Form
    {
        public _21110635_Bai3()
        {
            InitializeComponent();
        }

        private void _21110635_Bai3_Load(object sender, EventArgs e)
        {
            // tạo chuỗi chứa kết nối đên db
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            // tạo kết nối
            SqlConnection conn = new SqlConnection(strCon);
            try
            {
                // mở kết nối
                conn.Open();
                richTextBox1.Text = "Connection opened" +
                "\n Connection Properties:" +
                "\n \t " + conn.ConnectionString +
                "\n \t" + conn. Database +
                "\n \t" + conn.DataSource +
                "\n\t" + conn.State
                +
                "\n\t" + conn .WorkstationId;
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
