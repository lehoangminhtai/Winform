using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110635_Lê_Hoàng_Minh_Tài_ComplexNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private ComplexNumber x = new ComplexNumber();

        private ComplexNumber y = new ComplexNumber();

        private void firstButton_Click_1(object sender, EventArgs e)
        {
            x.Real = Int32.Parse(realTextBox.Text);

            x.Imaginary = Int32.Parse(imaginaryTextBox.Text);

            realTextBox.Clear();

            imaginaryTextBox.Clear();

            statusLabel.Text = "First Complex Number is: " + x;
        }

        private void secondButton_Click_1(object sender, EventArgs e)
        {
            y.Real = Int32.Parse(realTextBox.Text);

            y.Imaginary = Int32.Parse(imaginaryTextBox.Text);

            realTextBox.Clear();

            imaginaryTextBox.Clear();

            statusLabel.Text = "Second Complex Number is: " + y;
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            statusLabel.Text = x + " + " + y + " = " + (x + y);
        }

        private void subtractButton_Click_1(object sender, EventArgs e)
        {
            statusLabel.Text = x + " - " + y + " = " + (x - y);
        }

        private void MultiplyButton_Click_1(object sender, EventArgs e)
        {
            statusLabel.Text = x + " * " + y + " = " + (x * y);
        }
    }
}
