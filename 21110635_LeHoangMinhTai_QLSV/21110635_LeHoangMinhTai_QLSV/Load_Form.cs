using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110635_LeHoangMinhTai_QLSV
{
    public partial class Load_Form : Form
    {
     
        public Load_Form()
        {
            InitializeComponent();
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                backgroundWorker1.ReportProgress(i);
                progressBar1.Value = i;
                // Thực hiện công việc của bạn ở đây
            }

        }

 

       

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        private void Load_Form_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                // Wait 50 milliseconds.  
                Thread.Sleep(5);
                // Report progress.  
                backgroundWorker1.ReportProgress(i);

            }
            
           /* Application.Run(new Form1());
            this.Close();*/
            
        }

        private void backgroundWorker1_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            // Set the text.  
            this.Text = "Progress: " + e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
       
    }
}
