using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetPay();
            String filePath = "D:\\Winform\\Winform\\W4\\Lab04\\Lab04\\saveInfor.txt";
            FileStream fs = new FileStream(filePath, FileMode.Open,FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(fs);
            foreach (var item in listBox1.Items)
            {
                writer.WriteLine(item.ToString());
                writer.Flush();
            }
            fs.Close();
        }
        public void GetPay()
        {
            double total = 0;
            if (txtName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (chkClean.Checked) {
                    total += 100000;
                 }
                if (chkWhitening.Checked) {
                    total += 1200000;
                }
                if (chkXRay.Checked) {
                    total += 200000;
                }
                total += Convert.ToInt32(numFilling.Value) * 80000;


            }
            txtTotal.Text = total.ToString();
            /* listBox1.Items.Add(txtName.Text);
             listBox1.Items.Add(txtTotal.Text);*/
            string combinedText = $"{txtName.Text} - {txtTotal.Text}";
            listBox1.Items.Add(combinedText);

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*String filePath = "D:\\Winform\\Winform\\W4\\Lab04\\Lab04\\saveInfor.txt";
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(fs);*/
           
        }
    }
}
