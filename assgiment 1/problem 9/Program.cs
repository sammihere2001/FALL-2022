﻿using System;
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
        

            //Problem  9

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
