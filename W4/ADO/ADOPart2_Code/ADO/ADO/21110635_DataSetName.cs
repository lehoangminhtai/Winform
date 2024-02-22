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

namespace ADO
{
    public partial class _21110635_DataSetName : Form
    {
        public _21110635_DataSetName()
        {
            InitializeComponent();
        }



        private void button_DataSetName_Click(object sender, EventArgs e)
        {
            string strSQL = "select * from Employees ";
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com;
            Com = new SqlCommand(strSQL, Con);
            try
            {
                Con.Open();
                //tạo dataAdaptor
                SqlDataAdapter da = new SqlDataAdapter(strSQL, Con);
                // tạo DataSet rồng
                DataSet ds = new DataSet("Employees");
                //dua data vào bằng Fill()
                da.Fill(ds, "Employees");
                // lấy DataTable
                DataTable dt = ds.Tables["Employees"];
                // dua data ra
                dataGridView1.DataSource = dt;
                label1.Text = "DataSetName:" + ds.DataSetName;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: + ex.Message");
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();
                }
            }
            finally
            {
                Con.Dispose();
            }
        }

        private void buttonDataTable_Click(object sender, EventArgs e)
        {
            string strSQL = "select * from Customers ";
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            string dtName = "";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com;
            Com = new SqlCommand(strSQL, Con);
            try
            {
                Con.Open();
                //tạo dataAdaptor
                SqlDataAdapter da = new SqlDataAdapter(strSQL, Con);
                // tạo DataSet rồng
                DataSet ds = new DataSet("Customers");
                //dua data vào bằng Fill()
                da.Fill(ds, "Customers");
                // Query thứ 2
                strSQL = "select * from Orders";
                da = new SqlDataAdapter(strSQL, Con);
                // lấy DataTable
                DataTable dt = new DataTable();
                da.Fill(dt);
                // phuong thuc Add de them mot table moi vao ds.Tables.Add(dt);
                ds.Dispose();

                foreach (DataTable dataTable in ds.Tables)
                {
                    dtName += dataTable.TableName + "";
                    label1.Text = "Table name:" + dtName;
                    dataGridView1.DataSource = dt;
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();
                }
            }
            finally
            {
                Con.Dispose();
            }

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            string strSQL = "select * from Customers ";
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            string dtName = "";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com;
            Com = new SqlCommand(strSQL, Con);
            try
            {
                Con.Open();
                //tạo dataAdaptor
                SqlDataAdapter da = new SqlDataAdapter(strSQL, Con);
                // tạo Dataset rồng
                DataSet ds = new DataSet("Customers");
                //đua data vào bằng Fill()
                da.Fill(ds, "Customers");
                // Query thứ 2
                strSQL = "select * from Orders";
                da = new SqlDataAdapter(strSQL, Con);
                // lẫy DataTable
                DataTable dt = new DataTable(); da.Fill(dt);
                ds.Tables.Add(dt);
                ds.Dispose();
                // đua data ra
                // dùng foreach de duyet các table dua vào
                foreach (DataTable dataTable in ds.Tables)
                {
                    dtName += dataTable.TableName + "";
                }
                label2.Text = "Table name:" + ds.Tables[1].TableName;
                label2.Text = "số lượng Row:" + ds.Tables[1].Rows.Count.ToString();

                dataGridView1.DataSource = ds.Tables[1];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (Con.State != ConnectionState.Closed)
                {

                    Con.Close();
                }
            }
            finally
            {
                Con.Dispose();
            }
        }

        private void buttonCase_Click(object sender, EventArgs e)
        {
            string strSQL = @"select * from Customers";
            string strCon = @"Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            string dtName = "";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon; 
            SqlCommand Com = new SqlCommand(strSQL, Con);
            try
            {
                Con.Open();
                //tạo dataAdaptor
                SqlDataAdapter da = new SqlDataAdapter(strSQL, Con);
                // tạo Dataset rồng
                DataSet ds = new DataSet("Customers");
                ds.CaseSensitive = true;
                //đua data vào bằng Fill()
                da.Fill(ds, "Customers");
                // Query thứ 2
                strSQL = "select * from Orders";
                da = new SqlDataAdapter(strSQL, Con);
                // lấy DataTable
                DataTable dt = new DataTable();
                da.Fill(dt);
                ds.Tables.Add(dt);
                ds.Dispose();
                // đua data ra
                // dùng foreach de duyet các table dua vào
                foreach (DataTable dataTable in ds.Tables)
                {
                    dtName += dataTable.TableName + "";
                }
                if (dtName == "Orders")
                {
                    label1.Text = "Case Sensitive";
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    label1.Text = "Case Sentive False";
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (Con.State != ConnectionState.Closed)
                {
                }
                Con.Close();
            }
            finally
            {
                Con.Dispose();
            }
        }
    }
}
