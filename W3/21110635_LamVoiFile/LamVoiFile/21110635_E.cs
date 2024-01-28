using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamVoiFile
{
    public class _21110635_E
    {
        string filePath = @"D:\Winform\Winform\W3\test\test.txt";
        public void ktFile()
        {
            Console.WriteLine("21110635_LamVoiFile_E");
            // Kiểm tra đường dẫn này có tồn tại hay không?
            if (File.Exists(filePath))
            {
                // Xóa file
                File.Delete(filePath);
                // Kiểm tra lại xem file còn tồn tại không.
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File deleted...");
                }
                
            }
            else
            {
                Console.WriteLine("File test.txt does not yet exist!");
            }
        }
    }
}
