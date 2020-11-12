using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Epam_3._3
{

    public class Cicle
    {
        private double radius { get; set; }
        private double dj { get; set; }
        private double pl { get; set; }
        private double dj1 { get; set; }
        private const double Pi = 3.14;
        
        public double getradius()
        {
            Console.WriteLine("Enter radius: ");
            radius = double.Parse(Console.ReadLine());
            return radius;
        }
        
        public double getdj()
        {
            dj = 2 * Pi * getradius();
            return dj;
        }
         public double setdj1()
        {
            double a = getradius();
            dj1 = a * a;
            return dj1;
        }
        public double getpl()
        {
            
            pl =Pi * setdj1();
            return pl;
        }
        
    }

    class Prog1
    {

        static void Main(string[] args)
        {
            Cicle dj = new Cicle();
            Cicle pl = new Cicle();
            Console.WriteLine("length is: " + dj.getdj());
            Console.WriteLine("Plo4a is: " + pl.getpl());


        }

    }

}



