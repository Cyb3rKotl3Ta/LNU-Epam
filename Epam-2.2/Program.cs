using System;

namespace Epam_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name: ");
            string thirdname = Console.ReadLine();
            Console.WriteLine("Enter second name: ");
            string fourthname = Console.ReadLine();
            if (thirdname[0] == fourthname[0])
            {
                if (thirdname[thirdname.Length - 1] == fourthname[fourthname.Length - 1])
                {
                    Console.WriteLine("First and last symbole are the same");
                }

            }
            else
            {
                Console.WriteLine("First and last symbole not the same");
            }
        }
    }
}
