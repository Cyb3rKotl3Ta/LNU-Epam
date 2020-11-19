using System;
using System.Linq;

namespace Epam_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            double[] myArray =  { 12, 23, 14, 213423, 21, 1234, 23 };
           
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
            
        }
    }
}

//Console.WriteLine(myArray.Where(i => i % 2 == 0));