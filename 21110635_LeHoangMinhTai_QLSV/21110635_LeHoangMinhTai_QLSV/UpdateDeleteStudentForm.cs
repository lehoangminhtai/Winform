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

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            //STUDENT student = new STUDENT();
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAddress.Text;
            string gender = "Male";

            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            //  sv tu 10-100,  co the thay doi
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("Student Infor Updated!!!", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Edit Student!!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Chức năng kiểm tra dữ liệu vào
        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "")
                        || (textBoxLname.Text.Trim() == "")
                        || (textBoxAddress.Text.Trim() == "")
                        || (textBoxPhone.Text.Trim() == "")
                        || (pictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBoxID.Text);
                if ((MessageBox.Show("Are you sure you want to delete this student?","Delete Student",MessageBoxButtons.YesNo,MessageBoxIcon.Question))==DialogResult.Yes) {
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "DeleteStudent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Text = "";
                        textBoxFname.Text = "";
                        textBoxLname.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxStudentImage.Image = null;
                    }
                    else {
                        MessageBox.Show("Student Not Deleted","Delete Student",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else { }
            }
            catch  {
                MessageBox.Show("Please Enter A Valid Id!!","Delete Student",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
