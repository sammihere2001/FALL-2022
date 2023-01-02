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
            //QUESTION 1

            //Console.WriteLine("Enter Speed in miles per hour");
            //int m = Convert.ToInt32(Console.ReadLine());

            //double ans = m * 1.609 /3600;
            //Console.WriteLine("Speed in Kilometer per Second is :"+ ans);
            //Console.ReadKey();

            //PROBLEM 2

            //Console.WriteLine("Enter Number ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n == 0 || n < 0) {
            //    Console.WriteLine("Invalid Input");
            //}
            //else if ( n %2 == 0)
            //{
            //    Console.WriteLine(n +" is an Even number");
            //}
            //else if (n % 2 != 0)
            //{
            //    Console.WriteLine(n + " is an Odd number");
            //}
            //Console.ReadKey();

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
