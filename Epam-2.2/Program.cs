using System;

namespace Epam_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two surnames");
            var sur1 = Console.ReadLine();
            var sur2 = Console.ReadLine();
            string str1 = sur1;
            string str2 = sur2;
            var reslt = String.Equals(str1, str2);

            if (reslt == true)
            {
                Console.WriteLine("Surnames are equial");
            }
            else
            {
                Console.WriteLine("Surnames are not equial");
            }
            if (sur1.Length > sur2.Length)
            {
                Console.WriteLine("First surname is longer");
            }
            if (sur2.Length > sur1.Length)
            {
                Console.WriteLine("Second surname is longer");
            }
            if (sur1.Length == sur2.Length)
            {
                Console.WriteLine("Length is equial");
            }

            if (sur1[0] == sur2[0])
            {
                if (sur1[sur1.Length - 1] == sur2[sur2.Length - 1])
                {
                    Console.WriteLine("First and last char are equial");
                }
            }
            else
            {
                Console.WriteLine("First and last char are not equial");
            }
        }
    }
}




