using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreElementsInArray
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = new int[10];
            int i;
            Console.Write("\n\nRead and Print Elemnts of an array:\n");
            Console.Write("---------------------------------------\n");
            Console.Write("input 10 elements in the array:\n");
            for(i=0;i<10;i++)
            {
                Console.Write("element - {0}:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("/nElements in array are:\n");
            for(i=0;i<10;i++)
            {
                Console.Write("{0}  ", arr[i]);

            }
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
