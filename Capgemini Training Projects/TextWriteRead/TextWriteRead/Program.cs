using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextWriteRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\TextWR.txt";

            //Text Writing
            TextWriter writer = File.CreateText(path);
            writer.Write(DateTime.Now.ToString());
            Console.WriteLine("Successfully added Date and Time\n");
            writer.Close();

            //Text Reading
            TextReader reader = File.OpenText(path);
            Console.Write("Reading Current Time:");
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();

            Console.ReadKey();

        }
    }
}
