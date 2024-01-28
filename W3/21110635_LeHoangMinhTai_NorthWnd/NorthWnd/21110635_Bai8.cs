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
    public partial class _21110635_Bai8 : Form
    {
        public _21110635_Bai8()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void _21110635_Bai8_Load(object sender, EventArgs e)
        {
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            string strSql = @"select firstname, lastname from Employees";
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, conn);

            richTextBox1.Text = "Command được tạo và kết nối";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    richTextBox1.Text = "\n Connection opened" +
                        "\n Kết quả:" +
                        "\n \t " + reader[0].ToString() +
                        " " + reader[1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                label1.Text = "Connection closed";
            }
        }
    }
}
