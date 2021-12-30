using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStudent_Teacher
{
    class StudentAndTeacherTest
    {
        static void Main()
        {   
            //Create a Person and say Hello
            Person myperson = new Person();
            myperson.Greet();
            //Create a student, set his age,Greet and showage
            Student mystudent = new Student();
            mystudent.SetAge(21);
            mystudent.Greet();
            mystudent.ShowAge();
            //Create Teacher, 30 Years old, Say Hello and Explain
            Teacher myteacher = new Teacher();
            myteacher.SetAge(30);
            myteacher.Greet();
            myteacher.Explain();

            //If(debug)
            Console.ReadKey();

        }
    }
}
