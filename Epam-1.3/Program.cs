
using System;

namespace MathClassCS
{


    namespace Epam_1._3
    {
        class Program
        {
            static int Main()
            {
                int num1, num2;
                Console.WriteLine("Enter first number (1<num1<5): ");
                num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 1 || num1 > 5)
                {
                    Console.WriteLine("The condition is not met");
                    return 0;
                }
                Console.WriteLine("Enter second number (1<num2<5)");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 < 1 || num2 > 5)
                {
                    Console.WriteLine("The condition is not met");
                    return 0;
                }
                Console.WriteLine("first num ^ second num = " + Math.Pow(num1, num2));
                return 0;

            }
        }
    }
}