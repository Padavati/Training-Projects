using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice1
{
   public class program
    {
        public static void Main()
        {
            Laptop lp = new Laptop();
            lp.ShowDetails(Laptop.name,Laptop.price,Laptop.processor,Laptop.ram,Laptop.hdd);
            Console.WriteLine("\n\n--------------------------------------------------------\n\n");
            Console.ReadKey();
        }
    }
  
        
}
