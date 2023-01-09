using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFile
{
    class Program
    {
        public static long Ackerma(long a, long b)
        {
            if (a > 0)
            {
                if (b > 0)
                {
                    return Ackerma(a - 1, Ackerma(a, b - 1));
                }
                else if (b == 0)
                {
                    return Ackerma(a - 1, 1);
                }
            }
            else if (a == 0)
            {
                if (b >= 0)
                    return b + 1;
            }

            return b;
        }

        static void Main()
        {
            Console.WriteLine("Enter number of rows ");
            double i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Colums ");
            double j = Convert.ToInt32(Console.ReadLine());

            for (long m = 0; m <= i; ++m)
            {
                for (long n = 0; n <= j; ++n)
                {
                    Console.Write("\t" + Ackerma(m, n));
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

