using System;
using System.Runtime.CompilerServices;

namespace Epam_3._4
{
    public class Calculattte
    {
 

        static void Main()
        {
            Console.WriteLine("1: ");
            Calculatte(2, 2);
            Console.WriteLine("2: ");
            Calculatte(2, 2);
            Console.WriteLine("3: ");
            Calculatte(2, 2);
            Console.WriteLine("4: ");
            Calculatte(2, 2);
           

        }
        private static void Calculatte(double a, double b)
        {
            const double pi = 3.14;
            var res1 = (a + b) * 2;
            var res2 = a * b;
            var res3 = pi * (a * 2);
            var res4 = (a * a) * pi;
            Console.WriteLine("Per is: " + res1);
            Console.WriteLine("Pl is: " + res2);
            Console.WriteLine("2PiR is: " + res3);
            Console.WriteLine("PiR^2 is: " + res4);
        }
    }
}
