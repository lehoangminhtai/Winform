using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLieuData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("21110635_LeHoangMinhTai");
            string strSQL =  @"select unitprice, productname from products ";
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
                DataSet ds = new DataSet();
                //đua data vào bằng Fill()
                da.Fill(ds, "products");
                // lấy DataTable
                DataTable dt = ds.Tables["products"];

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.WriteLine(row[col]); Console.WriteLine("".PadLeft(20, '-'));
                    }
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
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
