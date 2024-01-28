using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110635_StreamReadWrite
{
    public class _21110635_A
    {
        public void A()
        {
            Console.WriteLine("21110635_StreamReadWrite_A");
            string filePath = @"D:\Winform\Winform\W3\test2.txt";
            string[] lines;
            string str;

            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath);
                Console.WriteLine("\n Doc theo dòng:");
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine("Line {0}: {1}", i, lines[i]);
                }
                Console.WriteLine();
                Console.WriteLine("\n Doc het van ban:");
                str = File.ReadAllText(filePath);
                Console.WriteLine("Chuoi can doc:\n {0}", str);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}

