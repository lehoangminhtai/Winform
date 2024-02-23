using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110635_ADO_binding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet dataSet;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MY_DB db =new MY_DB();
            string strQuery = "select EmployeeID, FirstName, LastName, Birthdate from Employees"; 
            dataSet = new DataSet("Employees");
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery,db.getConnection);
                sqlDataAdapter.Fill(dataSet);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
            this.dataGridView1.DataSource= dataSet.Tables[0];

        }

        private void btnGetChange_Click(object sender, EventArgs e)
        {
            DataSet dataSetChange = new DataSet("Change");
            try
            {

                dataSetChange = dataSet.GetChanges();
                // xét thay đổi dữ liệu
                if (dataSetChange != null)
                    this.dataGridView2.DataSource = dataSetChange.Tables[0];
                else
                
                    this.dataGridView2.DataSource = null;
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            dataSet.AcceptChanges();
            
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            dataSet.RejectChanges();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
        }

        private void btnWriteXML_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet.WriteXml(@"D:\Winform\Winform\W4\ADO\ADO_Binding_Code\TestXML.xml");
                MessageBox.Show("Ghi Thành Công!!!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Loi xay ra: "+ex.Message);
            }
        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            try {
                dataSet.ReadXml(@"D:\Winform\Winform\W4\ADO\ADO_Binding_Code\TestXML.xml");
            }
            catch(Exception ex) {
                MessageBox.Show("Loi xay ra" + ex.Message);
            }
            dataGridView2.DataSource = dataSet.Tables[0];
        }
    }
}

