using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStudent_Teacher
{
    class Student:Person
    { 
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to Class");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: 20 years old");
        }
    }
}
