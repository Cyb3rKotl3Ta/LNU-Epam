using System;

namespace Epam_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentensce: /n");
            string a = Console.ReadLine(), b = a.Replace("a", "u");
            Console.WriteLine(b);
        }
    }
}
