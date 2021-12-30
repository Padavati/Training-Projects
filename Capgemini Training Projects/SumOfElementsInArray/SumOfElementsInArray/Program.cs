using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfElementsInArray
{
    public class SumOfElementsInArray
    {
        public static void Main()
        {
            int[] arr = new int[3];
            int i,sum=0;
            Console.Write("\nThe number of Input Elements To be store in Array:3\n");
            Console.Write("\nThe 3 input elements are:\n");
            for(i=0;i<3;i++)
            {
                Console.Write("element 0-", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
   
            for(i=0;i<3;i++)
            {
                sum += arr[i];
                
            }
            Console.Write("\nThe sum Elements in the array is :{0}\n", sum);
            Console.ReadKey();
        }
        
    }
}
