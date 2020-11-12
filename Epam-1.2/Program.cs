using System;

namespace Epam_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
           
            double V = float.Parse(Console.ReadLine());

            double objem = Math.Pow(V, 3);

            Console.WriteLine("Objem is: " + objem);
                      
        }

    }
}
