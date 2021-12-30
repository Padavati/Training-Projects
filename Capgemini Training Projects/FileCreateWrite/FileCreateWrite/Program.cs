using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileCreateWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            File fl = new File();
            fl.CreateFile();
            Console.ReadKey();
        }
    }
  
}
