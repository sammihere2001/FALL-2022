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
        

            //Problem  2.5
             int i=0 , j=1 , f=0, n =0 ;
             Console.WriteLine("how many fibonacci numbers you want to print ?");
             n = Convert.ToInt32(Console.ReadLine());
             Console.Write(i);
             Console.Write(j);
             for (int c = 0; c < n-2 ; c++ )
             {
                 f = i + j;
                 i = j;
                 j = f;
                 Console.Write(f);

             }
             Console.ReadKey();
        }
    }
}
