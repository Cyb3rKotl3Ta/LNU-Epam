using System;
using System.Collections.Generic;
using System.Text;


namespace Epam_4._4
{
    interface IDrawable
    {
        void Draw();
    }
    class Figure : IDrawable
    {
        public float xxx { get; private set; }
        public float yyy { get; private set; }

        public Figure(float xxx, float yyy)
        {
            this.xxx = xxx;
            this.yyy = yyy;
        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Figure");
        }
    }
    class Rectangle : Figure, IDrawable
    {
        public Rectangle(float xxx, float yyy) : base(xxx, yyy)
        {

        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    class Square : Figure, IDrawable
    {
        public Square(float xxx, float yyy) : base(xxx, yyy)
        {

        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Square");
        }
    }
    class Program
    {
        static void DrawAll(params IDrawable[] array)
        {
            foreach (IDrawable drawable in array)
            {
                drawable.Draw();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter sides(2) of rectngl");
            Rectangle rect = new Rectangle(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            Console.WriteLine("Enter sides(1) of rectngl");
            Square sq = new Square(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            Console.WriteLine("Enter sides(2) of figure");
            Figure fig = new Figure(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));

            IDrawable rectDrawable = (IDrawable)rect;
            IDrawable sqDrawable = (IDrawable)sq;
            IDrawable figDrawable = (IDrawable)fig;

            DrawAll(rectDrawable, sqDrawable, figDrawable);
        }
    }
}
