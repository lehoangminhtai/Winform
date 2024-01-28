using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110635_LamVoiFile_YeuCau2
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo testFile = new FileInfo(@"D:\Winform\Winform\W3\test2.txt");
            {
                if (rdbt.Checked == true)
                    if (testFile.Exists)
                    {
                        rtShow.Text = testFile.FullName + " exist."
                        + "Creation time: " + testFile.CreationTime
                        + "Last Write Time " + testFile.LastWriteTime
                        + "Directory Name: " + testFile.DirectoryName;
                    }
                    else
                    {
                        rtShow.Text = testFile.FullName + " does not exist.";
                    }
            }
            if (rbt_CreateDic.Checked == true)
            {
                String dirPath = @"D:\Winform\Winform\W3\test";
                // Kiểm tra xem đường dẫn thư mục tồn tại không.
                bool exist = Directory.Exists(dirPath);
                // Nếu không tồn tại, tạo thư mục này.
                if (!exist)
                {
                    rtShow.Text = dirPath + " does not exist."
                            + "\n" + "Create directory: "
                            + dirPath + "\n" + "Nhan them 1 lần nua để hiện thị thông tin thư mục vừa tạo";
                    // Tạo thư mục.
                    Directory.CreateDirectory(dirPath);
                }
                else
                {
                    // Thư mục cha.
                    DirectoryInfo parentInfo = Directory.GetParent(dirPath);
                    rtShow.Text = "Directory Information" + dirPath + "\n" +
                        "Creation time:" + Directory.GetCreationTime(dirPath) + "\n" +
                    // Thời điểm cuối cùng thư mục có sự thay đổi.
                    "Last Write Time: " + Directory.GetLastWriteTime(dirPath) + "\n" +
                    "Parent directory:" + parentInfo.FullName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtShow.Text = " ";
        }
    }
}
