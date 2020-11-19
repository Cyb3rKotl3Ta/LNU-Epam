using System;

namespace Epam_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            double[] myArray = new double [6] { 2, 3, 4, 5, 6, 187 };
            double[] myArray1 = new double [6];
            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray1[i] = Math.Pow( myArray[i] , 3 );
                Console.WriteLine(myArray1[i]);
            }
        }
    }
}
