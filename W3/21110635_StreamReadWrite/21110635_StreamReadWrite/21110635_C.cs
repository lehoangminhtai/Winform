using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110635_StreamReadWrite
{
    public class _21110635_C
    {
        public void waf()
        {
            Console.WriteLine("21110635_StreamReadWrite_C");
            string fileLPath = @"D:\Winform\Winform\W3\test\test.txt";
            string fileSPath = @"D:\Winform\Winform\W3\test\test2.txt";
            string[] lines = new string[2];
            lines[0] = "Ghi theo dong C#.";
            lines[1] = "Dong thứ 1";
            File.WriteAllLines(fileLPath, lines);
            string str;
            str = "Ghi toàn bộ lines";
            File.WriteAllText(fileSPath, str);
        }
    }
}
