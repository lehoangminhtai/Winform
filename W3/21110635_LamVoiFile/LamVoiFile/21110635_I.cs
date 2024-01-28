using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamVoiFile
{
    public class _21110635_I
    {
        String dirPath = @"D:\Winform\Winform\W3\test";
        public void reD()
        {
            Console.WriteLine("21110635_LamVoiFile_I");
            // Nếu đường dẫn này tồn tại.
            if (!Directory.Exists(dirPath))
            {
                Console.WriteLine(dirPath + "does not exist.");
                Console.Read();
                return;
            }
            Console.WriteLine(dirPath + " exist");
            Console.WriteLine("Please enter a new name for this directory:");
            // String mà người dùng nhập vào.
            // Ví dụ: C:/test2/Java
            string newDirname = Console.ReadLine();
            if (newDirname == String.Empty)
            {
                Console.WriteLine("You not enter new directory name. Cancel rename.");
                Console.Read();
                return;
            }
            // Nếu đường dẫn mà người dùng nhập vào là tồn tại.
            if (Directory.Exists(newDirname))
            {
                Console.WriteLine("Cannot rename directory. New directory already exist.");
                Console.Read();
                return;
            }
            // Thư mục cha.
            DirectoryInfo parentInfo = Directory.GetParent(newDirname);
            // Tạo thư mục cha của thư mục mà người dùng nhập vào.
            Directory.CreateDirectory(parentInfo.FullName);
            //có thể đổi đường dẫn(path) của một thư mục.
            // nhưng phải đảm bảo đường dẫn cha của đường dẫn mới phải tồn tại.
            // (Nếu không ngoại lệ DirectoryNotFoundException sẽ được ném ra).
            Directory.Move (dirPath, newDirname);
            if (Directory.Exists(newDirname))
            {
                Console.WriteLine("The directory was renamed to " + newDirname);
            }
        }
    }
}
