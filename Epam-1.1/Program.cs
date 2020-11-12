using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius: ");
            double radius = float.Parse(Console.ReadLine());
            double s = radius * radius * Math.PI;
                
            Console.WriteLine(s);


            
        
         }
  
    }
}
      
        
        
         