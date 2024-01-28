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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void GetTable(string strSQL)
        {
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            listView1.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon; 
            SqlCommand Com;
            Com = new SqlCommand(strSQL, con);
            listView1.Columns.Add("First Name", 70, 0);
            listView1.Columns.Add("Last Name", 150, 0);
            //listView1.Columns.Add("Position", 200, 0);
            listView1.View = View.Details;
            ListViewItem item1;
           /* try
            {*/
                SqlDataReader dr;
                con.Open();
                dr = Com.ExecuteReader();
                while (dr.Read())
                {
                    item1 = new ListViewItem(dr[1].ToString());
                    item1.SubItems.Add(dr[2].ToString());
                    /*item1.SubItems.Add(dr[3].ToString());
                    item1.SubItems.Add(dr.GetString(3));*/
                listView1.Items.Add(item1);
                }
                dr.Close();
                dr.Dispose();
                con.Close();
           /* }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if(con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            finally
            {
                con.Dispose();
            }
*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SQL = "select * from ";
            SQL += "Employees";
            GetTable(SQL);
        }
    }
}
