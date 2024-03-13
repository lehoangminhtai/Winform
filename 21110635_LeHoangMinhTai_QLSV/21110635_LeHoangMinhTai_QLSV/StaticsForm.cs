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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Color panMaleColor;
        Color panFemaleColor;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            panMaleColor = panelMale.BackColor;
            panFemaleColor = panelFemale.BackColor;
            STUDENT student = new STUDENT();

            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));

            lblTotal.Text = ( total.ToString());
            lblPercentMale.Text = ("Male: " + maleStudentsPercentage.ToString("0.00") + "%");
            lblPercentFemale.Text = ("Female: " + femaleStudentsPercentage.ToString("0.00") + "%");
        }

        private void lblTotal_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void lblPercentMale_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
