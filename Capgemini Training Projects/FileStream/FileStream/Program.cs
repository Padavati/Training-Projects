using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating File
            string path = "E:\\FileStream.txt";
            FileStream fscreate = new FileStream(path, FileMode.Create);

            //Adding current date and time in Filestream
            byte[] bdata = Encoding.Default.GetBytes(DateTime.Now.ToString());
            fscreate.Write(bdata, 0, bdata.Length);
            Console.WriteLine("Data Added\n");
            fscreate.Close();

            //Reading File
            string data;
            FileStream fsread = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsread);
            data = sr.ReadToEnd();
            Console.WriteLine(data);
  

            
            Console.ReadKey();
        }
    }
}
