using System;

namespace MathClassCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a fractional number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Conditional is not met");
            }
            else
            {
                double aa = Math.Ceiling(a);
                Console.WriteLine(aa);
                Console.WriteLine(Math.Sqrt("Celling is: " + aa)); 
            }


        }
    }
}
