using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Stub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager mgr = new FileManager();
            mgr.FindLogFile(1024);

            Console.WriteLine($"Файлов, которые больше 1024 {mgr.FindLogFile(1024)}");
            Console.ReadKey();
        }
    }
}