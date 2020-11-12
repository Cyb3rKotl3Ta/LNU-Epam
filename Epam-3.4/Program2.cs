using System;

namespace Epam_3._2
{
    public class Rectangle
    {
        public double sideA
        { get; set; }
        public double sideB
        { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side1 and dide2");
            var rctngl = new Rectangle { sideA = double.Parse(Console.ReadLine()), sideB = double.Parse(Console.ReadLine()) };
            Console.WriteLine("Perimeter=" + (rctngl.sideA + rctngl.sideB) * 2);
            Console.WriteLine("Plo4a=" + rctngl.sideA * rctngl.sideB);
        }
    }
}