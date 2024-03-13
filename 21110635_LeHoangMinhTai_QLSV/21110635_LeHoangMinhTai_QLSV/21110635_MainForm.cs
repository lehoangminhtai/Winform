using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110635_LeHoangMinhTai_QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _21110635_AddStudentForm addStdF = new _21110635_AddStudentForm();
            addStdF.Show(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentListForm studentListForm = new studentListForm();
            studentListForm.Show(this);
        }



        private void editRemoveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteFrm = new UpdateDeleteStudentForm();
            updateDeleteFrm.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm staticsForm = new StaticsForm();
            staticsForm.Show();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm manage = new ManageStudentForm();
            manage.Show();
        }
    }
}
