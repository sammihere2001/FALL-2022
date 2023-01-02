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

            Console.WriteLine("Enter Speed in miles per hour");
            int m = Convert.ToInt32(Console.ReadLine());

            double ans = m * 1.609 / 3600;
            Console.WriteLine("Speed in Kilometer per Second is :" + ans);
            Console.ReadKey();







        }
    }
}
