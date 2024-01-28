using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21110635_LeHoangMinhTai_QLSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new studentListForm());
            Login_Form flogin = new Login_Form();
            if (flogin.ShowDialog() == DialogResult.OK)
            { Application.Run(new Form1()); }
            else
            { Application.Exit(); }
        }
    }
}
