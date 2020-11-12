using System;

namespace Epam_5._3
{
   enum Month {January, Febuary, March, April, May, June, July, August, September, October, November, December }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter num of Month: ");
            int numMonth = int.Parse(Console.ReadLine());
            if (numMonth > 12 || numMonth < 0)
            {
                Console.WriteLine("False num Enter 0-12");
                return;
            }
            string month = Enum.GetName(typeof(Month), numMonth);
            Console.WriteLine("Month:: \n" + "\t" + month);
        }
    }
    
}
