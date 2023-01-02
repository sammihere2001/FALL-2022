using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saim1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

           
            //PROBLEM 2

            Console.WriteLine("Enter Number ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0 || n < 0) {
                Console.WriteLine("Invalid Input");
            }
            else if ( n %2 == 0)
            {
                Console.WriteLine(n +" is an Even number");
            }
            else if (n % 2 != 0)
            {
                Console.WriteLine(n + " is an Odd number");
            }
            Console.ReadKey();









        }
    }
}
