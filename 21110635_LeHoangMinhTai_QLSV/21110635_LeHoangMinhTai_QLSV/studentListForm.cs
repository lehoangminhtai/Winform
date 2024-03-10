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
    public partial class studentListForm : Form
    {
        public studentListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        private void studentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet.std' table. You can move, or remove it, as needed.
            
            this.stdTableAdapter.Fill(this.qLSVDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGV.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGV.RowTemplate.Height = 80;
            dataGV.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGV.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGV.AllowUserToAddRows = false;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.stdTableAdapter.Fill(this.qLSVDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGV.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGV.RowTemplate.Height = 80;
            dataGV.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGV.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGV.AllowUserToAddRows = false;
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGV_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.textBoxID.Text = dataGV.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdF.textBoxFname.Text = dataGV.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.textBoxLname.Text = dataGV.CurrentRow.Cells[2].Value.ToString();

            updateDeleteStdF.dateTimePicker1.Value = (DateTime)dataGV.CurrentRow.Cells[3].Value;

            //gender
            if (dataGV.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
            {
                updateDeleteStdF.radioButtonMale.Checked = true;
            }
            else
            {
                updateDeleteStdF.radioButtonFemale.Checked = true;
            }
            updateDeleteStdF.textBoxPhone.Text = dataGV.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdF.textBoxAddress.Text = dataGV.CurrentRow.Cells[6].Value.ToString();

            //code xu ly hinh anh up len

            byte[] pic;
            pic = (byte[])dataGV.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.pictureBoxStudentImage.Image = Image.FromStream(picture);

            updateDeleteStdF.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
