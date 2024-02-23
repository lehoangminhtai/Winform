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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _21110635_ADO_binding
{
    public partial class _21110635_DataBinding : Form
    {
        public _21110635_DataBinding()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;
        BindingSource bdSource;
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dtRowCurrent = (DataRow)bdSource.Current;
            txtName.Text = dtRowCurrent["LastName"].ToString();
            txtTitle.Text = dtRowCurrent["Title"].ToString();
            dateTimePicker1.Text = dtRowCurrent["BirthDate"].ToString();
            label1.Text = "Record: " + (bdSource.Position + 1) + " of " + bdSource.Count;
            bdSource.PositionChanged += new EventHandler(bindingSource1_PositionChanged);
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _21110635_DataBinding_Load(object sender, EventArgs e)
        {
            bdSource = new BindingSource();
            MY_DB db = new MY_DB();
            string strQuery = "select LastName, Title, BirthDate from Employees";
            dataSet = new DataSet("Employees");

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, db.getConnection);
                sqlDataAdapter.Fill(dataSet);
                SqlCommandBuilder sqlComB = new SqlCommandBuilder(sqlDataAdapter);
                foreach(DataRow dtRow in dataSet.Tables[0].Rows)
                {
                    bdSource.Add(dtRow);
                }
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 11" + ex.Message);
            }
            
            this.dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = "Record: " + (bdSource.Position + 1) + " of " + bdSource.Count;
        }

        private void Show()
        {
            DataRow dtRowCurrent = (DataRow)bdSource.Current;
            txtName.Text = dtRowCurrent["LastName"].ToString();
            txtTitle.Text = dtRowCurrent["Title"].ToString();
            dateTimePicker1.Text = dtRowCurrent["BirthDate"].ToString();
            label1.Text = "Record: " + (bdSource.Position + 1) + " of " + bdSource.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bdSource.MoveFirst();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bdSource.MoveLast();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bdSource.Position == bdSource.Count - 1)
            {
                MessageBox.Show("Last record.", "Vi dụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bdSource.MoveNext();
                Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bdSource.Position == 0)
            {
                MessageBox.Show("First record.", "Vi dụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bdSource.MovePrevious();
                Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _21110635_DataBinding_Load(null,null);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtTitle.Text = "";
            dateTimePicker1.Value = DateTime.Now; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MY_DB dB = new MY_DB();
            string strQuery = "select LastName, FirstName, Title, BirthDate from Employees";
            dataSet = new DataSet("Employees");
            try
            {
                sqlDataAdapter = new SqlDataAdapter(strQuery, dB.getConnection);
                sqlDataAdapter.Fill(dataSet);
                SqlCommandBuilder sqlComB = new SqlCommandBuilder(sqlDataAdapter);
                // them
                DataRow drowEmployee = dataSet.Tables[0].NewRow();
                drowEmployee["FirstName"] = txtName.Text;
                drowEmployee["LastName"] = txtName.Text;
                drowEmployee["Title"] = txtTitle.Text;
                drowEmployee["BirthDate"] = dateTimePicker1.Text;
                dataSet.Tables[0].Rows.Add(drowEmployee);
                sqlDataAdapter.Update(dataSet);
                MessageBox.Show("Thêm thành công.", "Ví dụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _21110635_DataBinding_Load(null, null);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
