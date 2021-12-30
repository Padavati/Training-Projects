using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStudent_Teacher
{
    class Teacher:Person
    {
        private string Subject;
        public void Explain()
        {
            Console.WriteLine("Explanation Begins");
        }
    }
}
