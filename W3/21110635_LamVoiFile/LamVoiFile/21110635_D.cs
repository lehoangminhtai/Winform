using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamVoiFile
{
    public class _21110635_D
    {
        FileInfo testFile = new FileInfo(@"D:\Winform\Winform\W3\test\test.txt");
        public void infoFile()
        {
            Console.WriteLine("21110635_LamVoiFile_D");
            if (testFile.Exists)
            {
                Console.WriteLine(testFile.FullName + " exist.");
                // Thông tin thời điểm tạo file.
                Console.WriteLine("Creation time: "+ testFile.CreationTime);
                // Thông tin thời điểm file được sửa đổi lần cuối.
                Console.WriteLine("Last Write Time: "+ testFile. LastWriteTime);
                // Tên thư mục chứa file này.
                Console.WriteLine("Directory Name: "+ testFile.DirectoryName);
}
            else
            {
                Console.WriteLine(testFile.FullName + " does not exist.");
            }
        }
    }
}
