using System;
using System.IO;
using System.Linq;

namespace Epam_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            Console.WriteLine("Введiть повну або часткову назву директорii");
            path = Console.ReadLine();
            try
            {
                string[] dirs = Directory.GetFiles(@"D:\Epam", $"{path}*", SearchOption.AllDirectories);
                string a = $"{dirs[0]}";
                dirs = Directory.GetDirectories(@a, $"", SearchOption.AllDirectories);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
                string[] files = Directory.GetFiles(@a, $"{path}*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}