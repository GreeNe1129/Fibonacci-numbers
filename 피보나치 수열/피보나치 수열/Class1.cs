using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 피보나치_수열
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c = 1;
            int d = 0;

            string num = Console.ReadLine();

            for (int i = 0; i <= int.Parse(num); i++)
            {
                d = a + b + c;
                a = b;
                b = c;
                c = d;

                Console.WriteLine(d + " ");
            }
        }
    }
}
