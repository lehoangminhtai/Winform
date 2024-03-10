﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110635_LeHoangMinhTai_QLSV
{
    public partial class _21110635_AddStudentForm : Form
    {
        public _21110635_AddStudentForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateBdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void _21110635_AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                        || (TextBoxLname.Text.Trim() == "")
                        || (TextBoxAddress.Text.Trim() == "")
                        || (TextBoxPhone.Text.Trim() == "")
                        || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                STUDENT student = new STUDENT();
                int id = Convert.ToInt32(txtStudentID.Text);

                string fname = TextBoxFname.Text;
                if (!Regex.IsMatch(fname, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please enter a valid First Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string lname = TextBoxLname.Text;
                if (!Regex.IsMatch(lname, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please enter a valid Last Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime bdate = DateTimePicker1.Value;
                string phone = TextBoxPhone.Text;
                if (!Regex.IsMatch(phone, @"^\d{10}$"))
                {
                    MessageBox.Show("Please enter a valid 10-digit phone number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string adrs = TextBoxAddress.Text;
                string gender = "Male";

                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int born_year = DateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                //  sv tu 10-100,  co the thay doi
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);

                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
