using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class FileDataObject
    {
        public List<long> GetLengthFiles()
        {
            string path = @"C:\\Users\\pk\\Рабочий стол\\учёба\\Стандандартизация, сертификация и тех. документация";
            List<long> list = new List<long>();
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles();

            foreach (var file in files)
            {
                list.Add(file.Length);
            }

            return list;
        }
    }
}
