using System;


namespace Epam_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            double[] myArray = { 12, 23, 14, 213423, 21, 1234, 23 };
            double[] myArray1 = { 12, 23, 14, 213423, 21, 1234, 24 };
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == myArray1[i])
                {
                    //Console.WriteLine("Equival");
                }
                else
                {
                    ///Console.WriteLine("Not Equival");
                }
            }
            if(myArray == myArray1)
            {
                Console.WriteLine("Are equival");
            }
            else
            {
                Console.WriteLine("Are not equival");
            }
        }
    }
}
