using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingApp
{
    class Constructor //Parent class
    { 
        public Constructor()
        {

        }
        public Constructor(int studId, string name)
        {

        }
        public Constructor(int[] studentlist)
        {

        }
        public void DisplayStudentDetails()
        {

        }
      
    }
    class Staff:Constructor //Child CLass
    {
        public void StaffForStudents()
        {
            int[] constuctorlist = new int[2];
            Constructor constructorObj = new Constructor();
            Constructor constructorObj = new Constructor(11, "G");
            constructorObj.Constructor();//constructor 1 will be called 

            //constructorObj.DisplayStudentDetails();

        }
    }
}
