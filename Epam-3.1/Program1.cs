using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Epam_3._1
{
   
   public class Rectangle
    {
        private double sideA { get; set; }
        private double sideB { get; set; }
        public double getsideA()
        {
            Console.WriteLine("Enter num1: ");
            sideA = double.Parse(Console.ReadLine());
            return sideA;
        }
        public double getsideB()
        {
            Console.WriteLine("Enter num2: ");
            sideB = double.Parse(Console.ReadLine());
            return sideB;
        }
        public double getper()
        {
            double per;
            per = (getsideA() + getsideB()) * 2;
            return per;
        }
        public double getpl()
        {
            double pl;
            pl = getsideA() * getsideB();
            return pl;
        }

    }

    class Prog1
    {

        static void Main(string[] args)
        {
            Rectangle per = new Rectangle();
            Rectangle pl = new Rectangle();
            Console.WriteLine("Perimetr is: " + per.getper());
            Console.WriteLine("Plo4a is: " + pl.getpl());


        }

    }

}



