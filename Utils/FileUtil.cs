using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedWorker.Utils
{
    public class FileUtil
    {
        public static string EncodeBase64(string filePath)
        {

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int fsLen = (int)fs.Length;
                byte[] buffer = new byte[fsLen];
                fs.Read(buffer, 0, fsLen);
                // string res = Encoding.UTF8.GetString(buffer);
                return Convert.ToBase64String(buffer);
            }

        }
    }
}
