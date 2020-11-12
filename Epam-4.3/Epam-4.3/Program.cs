using System;

namespace Epam_4._3
{
    abstract class Figure
    {
        public float xxx { get; private set; }
        public float yyy { get; private set; }

        protected Figure(float xxx, float yyy)
        {
            this.xxx = xxx;
            this.yyy = yyy;
        }

        public abstract void Draw();
    }
    class Rectangle : Figure
    {
        public Rectangle(float xxx, float yyy) : base(xxx, yyy)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    class Square : Figure
    {
        public Square(float xxx, float yyy) : base(xxx, yyy)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
    class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num for sqr and first num for rectngl: ");
            Rectangle rect = new Rectangle(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            Console.WriteLine("Enter second num for rectngl: ");
            Square sq = new Square(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));

            sq.Draw();
            rect.Draw();
        }
       
        }
}
