using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StreamWriteRead
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating And Writing
            StreamWriter sw = new StreamWriter("E:\\StreamRW.txt");
            sw.Write(DateTime.Now.ToString());
            sw.Close();
            Console.WriteLine("Successfully added Date and Time");

            //Reading File

            StreamReader sr = new StreamReader("E:\\StreamRW.txt");
            Console.Write("\nReading Current Time:");
            Console.WriteLine(sr.ReadToEnd());
           
            
            sw.Close();
            

            
            Console.ReadKey();
        }
    }
}
