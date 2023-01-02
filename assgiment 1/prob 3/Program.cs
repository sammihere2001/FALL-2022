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
            

            PROBLEM 3

            Console.WriteLine("Enter Gender M : Male or F :Female  ");
            string n =Console.ReadLine();
            Console.WriteLine("Enter Age ");
            int a = Convert.ToInt32( Console.ReadLine());

            if (n == "M" && a >= 18)
            {
                Console.WriteLine("You are an Adult");
            }
            else if (n == "F" && a >= 16)
            {
                Console.WriteLine("You are an Adult");
            }
            else if (n == "F" && a < 16)
            {
                Console.WriteLine("You are a Minor");
            }
            else if (n == "M" && a < 18)
            {
                Console.WriteLine("You are a Minor");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadLine();



        }
    }
}
