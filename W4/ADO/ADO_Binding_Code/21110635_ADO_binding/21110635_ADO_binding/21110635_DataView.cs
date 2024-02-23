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

namespace _21110635_ADO_binding
{
    public partial class _21110635_DataView : Form
    {
        public _21110635_DataView()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        DataView dataView;
        private void _21110635_DataView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select * from Customers";
            dataTable = new DataTable("Customers");

             try
             {
                 SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                 sqlDataAdapter.Fill(dataTable);
                 sqlDataAdapter.Dispose();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error: 11" + ex.Message);
             }
            dataView = new DataView(dataTable);
            this.dataGridView1.DataSource = dataView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select * from Customers";
            dataTable = new DataTable("Customers");

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 11" + ex.Message);
            }
            dataView = new DataView(dataTable,"ContactTitle = 'Owner'","CustomerID",DataViewRowState.Unchanged);
            this.dataGridView1.DataSource = dataView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select * from Customers";
            dataTable = new DataTable("Customers");

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 11" + ex.Message);
            }
            dataView = new DataView(dataTable);
            label4.Text = "Number of Customer: " + dataView.Count.ToString();
            this.dataGridView1.DataSource = dataView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select * from Employees";
            dataTable = new DataTable("Employees");

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 11" + ex.Message);
            }
            dataView = new DataView(dataTable);
            if (textBox1.Text !="")
            {
                String strFilter = "FirstName like '%" + textBox1.Text+"%'";
                strFilter += " or LastName like '%" + textBox1.Text + "%'";
                dataView.RowFilter = strFilter;
            }
            label4.Text = "Number of Employee (s): " + dataView.Count.ToString();
            this.dataGridView1.DataSource = dataView;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select * from Employees";
            dataTable = new DataTable("Employees");

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 11" + ex.Message);
            }
            dataView = new DataView(dataTable);
            dataView.Sort = "FirstName ASC";
            // dùng khi sort nhiều cột
            // dataView.Sort = "FirstName ASC, LastName ASC";
            this.dataGridView1.DataSource = dataView;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select * from Region";
            dataTable = new DataTable("Region");

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 11" + ex.Message);
            }
            dataView = new DataView(dataTable);
           if(textBox2.Text != "")
            {
                DataRowView rowView = dataView.AddNew();
                rowView["RegionID"] = textBox2.Text;
                rowView["RegionDescription"] = textBox3.Text;
                rowView.EndEdit();
            }
            this.dataGridView1.DataSource = dataView;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(dataView != null)
            {
                try
                {
                    dataView.Delete(0);
                    label4.Text = "Number of "+dataTable.ToString() +" (s): " +dataView.Count.ToString();
                }
                catch {
                    MessageBox.Show("Dữ liệu rỗng!!");
                }
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select * from Employees";
            DataSet dataSet = new DataSet("Employees");

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                sqlDataAdapter.Fill(dataSet);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 11" + ex.Message);
            }
            
            this.dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select FirstName, LastName from Employees";
            dataTable = new DataTable("Employees");

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 11" + ex.Message);
            }
            
            this.dataGridView1.DataSource = dataTable;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select FirstName, LastName, Title from Employees";
            dataTable = new DataTable("Employees");

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 11" + ex.Message);
            }
            dataView = new DataView(dataTable);
            this.dataGridView1.DataSource = dataView;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
