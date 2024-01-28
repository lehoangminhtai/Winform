using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamVoiFile
{
    public class _21110635_F
    {
        public void PrintDirectory(string dirPath) {
            Console.WriteLine("21110635_LamVoiFile_F");
            try
            {
                // Nếu bạn không có quyền truy cập thư mục 'dirPath'
                // một ngoại lệ UnauthorizedAccessException sẽ được ném ra.
                IEnumerable<string> enums = Directory.EnumerateDirectories(dirPath);
                List<string> dirs = new List<string>(enums);
                foreach (var dir in dirs)
                {
                    Console.WriteLine(dir);
                    PrintDirectory(dir);

                }
            }

            // Lỗi bảo mật khi truy cập vào thư mục mà bạn không có quyền.
            catch (UnauthorizedAccessException e)
            {

                Console.WriteLine("Can not access directory: " + dirPath);
                Console.WriteLine(e.Message);

            }
        }
    }
}
