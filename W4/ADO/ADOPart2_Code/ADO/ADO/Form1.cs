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

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string strSQL = "select unitprice, productname from products ";
            string strCon = "Data Source=ADMIN-PC;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com = new SqlCommand(strSQL, Con);

            try
            {
                Con.Open();
                //tạo dataAdaptor
                SqlDataAdapter da =  new SqlDataAdapter(strSQL, Con);
                // tạo DataSet rồng
                DataSet ds = new DataSet();
                //dua data vào bằng Fill()
                da.Fill(ds, "products");
                // lấy DataTable
                DataTable dt = ds.Tables["products"];
                // dua data ra
                dataGridView1.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (Con.State != ConnectionState.Closed)
                    Con.Close();
            }

            finally
            {
                Con.Dispose();
            }
            //this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }
    }
}
