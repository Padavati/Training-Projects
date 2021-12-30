using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File1
{
    class Lavanya
    {
        public void Address()
        {
            //create file

            FileStream Obj = new FileStream("C:\\Desktop\\Address.txt",FileMode.Create,FileAccess.Write);

            //write into File

            StreamWriter stream = new StreamWriter(Obj);
            stream.WriteLine("Welcome");
            stream.Close();
            Obj.Close();
        }
    }
}
