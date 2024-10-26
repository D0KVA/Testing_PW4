using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stub
{
    public class FileManager
    {

        public int FindLogFile(long sizeThreshold)
        {
            //FileDataObject obj = new FileDataObject(); 
            TestDataObject obj = new TestDataObject();

            int count = 0;
            foreach (long file in obj.GetLengthFiles())
            {
                if (file > sizeThreshold)
                {
                    count++;
                }
            }

            return count;
        }

    }
}