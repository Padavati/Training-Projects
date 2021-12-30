using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArray
{
    public class ReverseAnArray
    {
        public static void Main()
        {
            int[] arr = new int[3];
            int i;
            Console.Write("The Number of input elements to store in array:3\n");
            Console.Write("input 3 number of elements in the array:\n");
            for (i = 0; i<3; i++)
            {
                Console.Write("element 0-", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("the values to store in the array:\n");
            for(i=0;i<3;i++)
            {
                Console.Write("{0}", arr[i]);
            }
            Console.Write("\nthe reverse order of inputs are:\n");
            for(i=3-1;i>=0;i--)
            {
                Console.Write("{0}", arr[i]);
             
            }
            Console.ReadKey();

        }
    }
}
