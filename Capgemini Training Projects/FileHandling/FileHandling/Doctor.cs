using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileHandling
{
    class Doctor
    {
        public void DoctorAddress()
        {
            //file creation

            FileStream filestreamObj = new FileStream("Lav.txt", FileMode.Create, FileAccess.Write);

            //file write operation

            StreamWriter sw = new StreamWriter(filestreamObj);
            
            sw.WriteLine("Welcome To India");
            sw.WriteLine("Hello World");

            sw.Close();
            filestreamObj.Close();
            
                
        }
    }
}
