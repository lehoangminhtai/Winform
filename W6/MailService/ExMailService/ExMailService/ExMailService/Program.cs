using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExMailService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new frmOTP());
           Form1 frmRegister = new Form1();
            if(frmRegister.ShowDialog() == DialogResult.OK)
            {
               Application.Run(new frmOTP());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
