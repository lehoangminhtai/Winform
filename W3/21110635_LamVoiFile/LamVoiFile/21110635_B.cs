using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LamVoiFile
{
    public class _21110635_B
    {
        String dirPath = @"D:\Winform\Winform\W3\test";
        public void di()
        {
            // Kiểm tra xem đường dẫn thư mục tồn tại không.
            bool exist = Directory.Exists(dirPath);
            // Nếu không tồn tại, tạo thư mục này.
            if (!exist)
            {
                Console.WriteLine(dirPath + " does not exist."); Console.WriteLine("Create directory:" + dirPath);
                // Tạo thư mục.
                Directory.CreateDirectory(dirPath);
            }
            Console.WriteLine("21110635_LamVoiFile_B");
            Console.WriteLine("Directory Information" + dirPath);
            // In ra các thông tin thư mục trên.
            // Thời điểm tạo thư mục.
            Console.WriteLine("Creation time:" + Directory.GetCreationTime(dirPath));
            // Thời điểm cuối cùng thư mục có sự thay đổi.
            Console.WriteLine("Last Write Time:" + Directory.GetLastWriteTime(dirPath));
            // Thư mục cha.
            DirectoryInfo parentInfo = Directory.GetParent(dirPath);
            Console.WriteLine("Parent directory:" + parentInfo.FullName);
        }
    }
}
