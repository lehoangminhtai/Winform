using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamVoiFile
{
    public class _21110635_A
    {
        DirectoryInfo dirInfo = new DirectoryInfo(@"D:\Winform\W3\LamVoiFile");
        public void showDI()
        {
            // Ghi ra các thông tin.
            // Thông tin ngày tạo file.
            Console.WriteLine("21110635_LamVoiFile_A");
            Console.WriteLine("Creation time:" + dirInfo.CreationTime);
            // Thông tin thời điểm file được sửa đổi lần cuối.
            Console.WriteLine("Last Write Time" + dirInfo. LastWriteTime);
            // Tên thư mục.
            Console.WriteLine("Directory Name:" + dirInfo.FullName);
            // Một mảng các thư mục con.
            DirectoryInfo[] childDirs = dirInfo.GetDirectories();
            // Mảng các file nằm trong thư mục.
            FileInfo[] childFiles = dirInfo.GetFiles();
            foreach (DirectoryInfo childDir in childDirs)
            {
                Console.WriteLine(" - Directory:" + childDir.FullName);
            }
            foreach (FileInfo childFile in childFiles)
            {
                Console.WriteLine(" - File:" + childFile.FullName);
            }
        }
    }
}
