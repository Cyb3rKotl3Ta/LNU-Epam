using System;

namespace Epam_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that is not a multiple of 2: ");

            double a = Convert.ToDouble(Console.ReadLine());
            if (a <= 2 || a % 2 == 0)
            {
                Console.WriteLine("The condition is not met, tyr again ");

            }
            else
            {
                double b = a / 2;
                Console.WriteLine("Number is: " + b);

            }

        }
    }
}