using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110635_StreamReadWrite
{
    public class _21110635_D
    {
        public void write() {
            Console.WriteLine("21110635_StreamReadWrite_D");
            Console.WriteLine("\n Vi du minh hoa doc va ghi File trong C#");
            Console.WriteLine("-- -");
            string[] names = new string[] { "Boss", "Hourly Worker", "Commission Workers", "Part Time" };
            StreamWriter sw = new StreamWriter(@"D:\Winform\Winform\W3\test\test.txt");
            foreach (string s in names)
            {
                sw.WriteLine(s);
            }
            
            sw.Close();
            // doc va hien thi du lieu trong textfile.txt
            string line = "";
            StreamReader sr= new StreamReader(@"D:\Winform\Winform\W3\test\test.txt");
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
