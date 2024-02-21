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

namespace _21110635_Linq2SQL
{
    public partial class Form1 : Form
    {
         
        QLNVien nv = new QLNVien();
        _21110635_NvTableDataContext db = new _21110635_NvTableDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //this.qLNVienTableAdapter.Fill(this.linq2SqlDataSet.QLNVien);
            try
            {
                var list = (from s in db.QLNViens select s).ToList();
                dataGridView1.DataSource = list;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                nv = new QLNVien();
                nv = db.QLNViens.Where(s => s.emID == txt_EmpID.Text).Single();

                if (string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_Dept.Text))
                {
                    MessageBox.Show("Please enter all required information.");
                    return;
                }

                if (txt_Name.Text.Length > 50 || txt_Dept.Text.Length > 50)
                {
                    MessageBox.Show("Input length exceeds the allowed limit.");
                    return;
                }

                nv.Name = txt_Name.Text;
                nv.Dept = txt_Dept.Text;

                db.SubmitChanges();
                Form1_Load(sender, e);


            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Employee with the specified ID not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.QLNViens.Any(s => s.emID == txt_EmpID.Text))
                {
                    MessageBox.Show("Cannot add an entity that already exists.");
                    return;
                }

                if (string.IsNullOrEmpty(txt_EmpID.Text) || string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_Dept.Text))
                {
                    MessageBox.Show("Please enter all required information.");
                    return;
                }

                if (txt_EmpID.Text.Length > 10 || txt_Name.Text.Length > 50 || txt_Dept.Text.Length > 50)
                {
                    MessageBox.Show("Input length exceeds the allowed limit.");
                    return;
                }
                nv = new QLNVien();

                nv.emID = txt_EmpID.Text;
                nv.Name = txt_Name.Text;
                nv.Dept = txt_Dept.Text;
                txt_EmpID.Text = "";
                txt_Name.Text = "";
                txt_Dept.Text = "";

                db.QLNViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                nv = db.QLNViens.Where(s => s.emID == txt_EmpID.Text).Single();
                nv.Name = txt_Name.Text;
                nv.Dept = txt_Dept.Text;
                db.QLNViens.DeleteOnSubmit(nv);
                db.SubmitChanges();
                Form1_Load(sender, e);
                txt_EmpID.Text = "";
                txt_Name.Text = "";
                txt_Dept.Text = "";
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Employee with the specified ID not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Find_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in db.QLNViens
                        where s.emID.Contains(txt_Find.Text) ||
                 s.Name.Contains(txt_Find.Text) || s.Dept.Contains(txt_Find.Text)
                        select s).ToList();

            dataGridView1.DataSource = list;
            txt_EmpID.DataBindings.Clear();
            txt_Name.DataBindings.Clear();
            txt_Dept.DataBindings.Clear();

            txt_EmpID.DataBindings.Add("text", list, "emID");
            txt_Name.DataBindings.Add("text", list, "Name");
            txt_Dept.DataBindings.Add("text", list, "Dept");
        }
    }
}
