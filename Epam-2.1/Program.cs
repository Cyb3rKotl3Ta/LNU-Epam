using System;

namespace Epam_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter users name separated by commas: ");
            var str1 = Console.ReadLine();
            var str2 = str1.Replace(",", " ");
            string end = str2;
            Console.WriteLine(end.ToLower());
        }
    }
}
