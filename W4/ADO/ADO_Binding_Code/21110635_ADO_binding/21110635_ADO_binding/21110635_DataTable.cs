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
    public partial class _21110635_DataTable : Form
    {
        public _21110635_DataTable()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        private void btnShow_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            string strQuery = "select top 10 * from Employees";
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
            label1.Text = dataTable.TableName;
        }

        private void btnRows_Click(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                string name = "";
                label3.Text = "Số Row: " + dataTable.Rows.Count.ToString();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    name += Convert.ToString(dataRow[2]) + "\n";
                }
                label2.Text = name;
            }
        }

        private void btnColumn_Click(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                string name = "";
                label3.Text = "Số Column: " + dataTable.Columns.Count.ToString();
                foreach (DataColumn dataColumn in dataTable.Columns)
                {
                    name += Convert.ToString(dataColumn.ToString()) + "\n";
                }
                label2.Text = name;
            }
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            dataTable = new DataTable("SinhVien");
            try
            {

                dataTable.Columns.Add("StID", System.Type.GetType("System.Double"));
                dataTable.Columns.Add("StudentName", System.Type.GetType("System.String"));
                dataTable.Columns.Add("Class", System.Type.GetType("System.String")); dataTable.Columns.Add("Subject", System.Type.GetType("System.String"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            this.dataGridView1.DataSource = dataTable;
        }

        private void btnAddRows_Click(object sender, EventArgs e)
        {
            object[] obj = new object[4] { 081101, "Nguyen van Anh", "0811A", "Winform" }; 
            dataTable.Rows.Add(obj);
            obj = new object[4] { 091103, "Tran Minh Hoang", "091102A", "Visual basic" }; 
            dataTable.Rows.Add(obj);
        }

        DataTable dataTableClone;
        private void btnClone_Click(object sender, EventArgs e)
        {
            dataTableClone = new DataTable();
            try
            {
                dataTableClone = dataTable.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            
            this.dataGridView2.DataSource = dataTableClone;
        }

        private void btnInputData_Click(object sender, EventArgs e)
        {
            dataTableClone = new DataTable();
            try {
                dataTableClone = dataTable.Clone();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {// dụng phương thức ImportRow để đưa dữ liệu vào
                    dataTableClone.ImportRow(dataTable.Rows[i]);
                }
                object[] obj = new object[4] { 0711032, "Truong Van Binh", "07110A", "LapTrinh Doi Tuong" };
                dataTableClone.Rows.Add(obj);
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.dataGridView2.DataSource = dataTableClone;
        }

        private void _21110635_DataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
