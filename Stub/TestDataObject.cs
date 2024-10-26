using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class TestDataObject
    {
        public List<long> GetLengthFiles()
        {
            List<long> list = new List<long>();
            list.Add(5034);
            list.Add(2080);
            list.Add(3012);
            list.Add(1024);

            return list;
        }
    }
}
