using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctorObj = new Doctor();
            doctorObj.DoctorAddress();

            Console.ReadLine();
            Console.ReadKey();
        }
        
    }
}
