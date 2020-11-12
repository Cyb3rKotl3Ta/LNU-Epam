using System;
using System.Reflection;

namespace Epam_4._1
{


    abstract class Figure
    {
        readonly int xxx;
        readonly int yyy;
        public Figure(int xxx, int yyy)
        {
            this.xxx = xxx;
            this.yyy = yyy;
        }
        public abstract void Draw();


    }


    class Square : Figure
    {
        public Square(int aaa) : base(aaa, aaa) { }
        public override void Draw()
        {
            Console.WriteLine("Draw Square");


        }
    }
    class Rectangle : Figure
    {
        public Rectangle(int xxx, int yyy) : base(xxx, yyy) { }
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");


        }

    }

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter sideA and sideB");
            Console.WriteLine("sideA: ");
            int _x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sideB: ");
            int _y = Convert.ToInt32(Console.ReadLine());
            Square a = new Square(_x);
            a.Draw();
            Rectangle b = new Rectangle(_x, _y);
            b.Draw();

        }
    }
}
