using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110635_StreamReadWrite
{
    public class _21110635_B
    {
        public void B()
        {

            Console.WriteLine("21110635_StreamReadWrite_B");

            Console.WriteLine("\nDoc noi dung File trong C#"); 
            Console.WriteLine(" -");
            try
            {
                // tao instance cua StreamReader de doc mot file.
                // lenh using cung duoc su dung de dong StreamReader.
                using (StreamReader sr = new StreamReader(@"D:\Winform\Winform\W3\test2.txt"))
                {
                    string line;
                    // doc va hien thi cac dong trong file cho toi
                    // khi tien toi cuoi file.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    
                }
            }
            catch (Exception e)
            {
                // thong bao loi.
                Console.WriteLine("Khong the doc du lieu tu file da cho: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
