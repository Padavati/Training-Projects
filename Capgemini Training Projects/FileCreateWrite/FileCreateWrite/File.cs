using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileCreateWrite
{
    class File
    {
        public void CreateFile()
        {
            string path = "E:\\NewFile.txt";

            // File Creation
            FileStream Obj = new FileStream(path, FileMode.Create, FileAccess.Write);
            Console.WriteLine("File  Created:");
            Obj.Close();
            Console.ReadLine();
            //Write into File
            StreamWriter stream = new StreamWriter(Obj);
            stream.WriteLine("Welcome To My Home");

            string Name = "Lavanya";
            stream.WriteLine("Name:" + Name);

            string Village = "Cherlopalli";
            stream.WriteLine("Village:" + Village);

            string City = "Tirupati";
            stream.WriteLine("City:" + City);

            string State = "AP";
            stream.WriteLine("State:" + State);

         
            Console.ReadLine();



        }

        
    }
}
