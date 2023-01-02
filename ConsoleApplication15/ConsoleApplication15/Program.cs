using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Enter Gender M : Male or F :Female  ");
        //    string n = Console.ReadLine();
        //    Console.WriteLine("Enter Age ");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Distance ");
        //    int d = Convert.ToInt32(Console.ReadLine());
        //    int i = 1,ans;

        //    if (n == "M" && a >= 18 )
        //    {
        //        ans = d * i;
        //        Console.WriteLine("You are an Adult pay 10pkr ");
        //    }
        //    else if (n == "F" && a >= 16)
        //    {
        //        Console.WriteLine("You are an Adult pay 10pkr");
        //    }
        //    else if (n == "F" && a < 16)
        //    {
        //        Console.WriteLine("You are a Minor pay 5pkr");
        //    }
        //    else if (n == "M" && a < 18)
        //    {
        //        Console.WriteLine("You are a Minor pay 5pkr");
        //    }
        //    Console.WriteLine("Five Kilometers have passed , do you want to travel more 5 km ?");
        //    int p = Convert.ToInt32(Console.ReadLine());
        //    if (p < 4 && n == "M" && a >= 18)
        //    { Console.WriteLine("pay 5pkr ");
        //    }
        //    if (p < 4 && n == "F" && a >= 16)
        //    {
        //        Console.WriteLine("pay 5pkr ");
        //    }
           
        //    Console.ReadLine();

             Console.WriteLine("Number of Rows you want to print the pattern ");
             int n = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i <= n; i++)
             {
                 for (int j = 0; j < i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             Console.ReadKey();
        }
    }
}
