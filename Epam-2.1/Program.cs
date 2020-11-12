using System;

namespace Epam_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter second Name: ");
            string secondname = Console.ReadLine();

            bool result = firstname.Equals(secondname, System.StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Ordinal Comparison: {0} and {1} are {2}", firstname, secondname, result ? "equal. " : "not equal. ");




        }

    }
}
