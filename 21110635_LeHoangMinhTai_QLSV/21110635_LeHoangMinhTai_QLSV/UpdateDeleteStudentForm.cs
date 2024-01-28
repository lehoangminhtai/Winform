using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110635_LeHoangMinhTai_QLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        STUDENT student = new STUDENT();
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname,lname, bdate,gender, phone, address,picture FROM std WHERE id = "+id);

            DataTable table = student.getStudents(command);

            if(table.Rows.Count > 0 )
            {
                textBoxFname.Text = table.Rows[0]["fname"].ToString();
                textBoxLname.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                //gender
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = true;
                }
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxStudentImage.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found","Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
         
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)){
                e.Handled= true;
            }
        }
        

    }
}
