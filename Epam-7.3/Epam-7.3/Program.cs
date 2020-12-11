using System;
using System.Collections.Generic;

namespace Epam_7._3
{
    class Program
    {
        public static List<string> str;
        static void Main(string[] args)
        {
            str = new List<string>(100);
            Random randm = new Random();
            string temp;

            for (int i = 0; i < 100; i++)
            {
                temp = "";
                for (int j = 0; j < 4; j++)
                {
                    temp += (char)((randm.Next() % 26) + 65);
                }

                str.Add(temp);
            }

            Console.WriteLine("Amount of symbols without set: {0}", str.Count);

            while (str.FindIndex(l => l[0] == 'Z') != -1)
            {
                str.RemoveAt(str.FindIndex(l => l[0] == 'Z'));
            }

            Console.WriteLine("Amount of symbols with set: {0}", str.Count);

            str.Sort();
            for (int i = 0; i < str.Count / 2; i++)
            {
                temp = str[i];
                str[i] = str[str.Count - 1 - i];
                str[str.Count - 1 - i] = temp;
            }

            while (true)
            {
                Console.WriteLine("\nEnter nub of page: ");
                if (!int.TryParse(Console.ReadLine(), out int pageNum))
                    break;
                pageNum--;
                DisplayPage(pageNum);
            }

            return;
        }
        public static void DisplayPage(int pageNum)
        {
            if (pageNum * 5 > str.Count || pageNum < 0)
            {
                Console.Write("Error. Enter another page");
                return;
            }
            for (int i = pageNum * 5; !(i >= (pageNum * 5) + 5 || i >= str.Count); i++)
            {
                Console.Write(str[i] + "  ");
            }
             return;
        }
    }
}