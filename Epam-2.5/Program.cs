using System;
using System.Globalization;
using System.Threading;
namespace Epam_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter number of task (1-4)");
            string CaseSwitch = Console.ReadLine();
            if (CaseSwitch == "Exit")
            {
                goto exit;
            }

            while (CaseSwitch == "1" || CaseSwitch == "2" || CaseSwitch == "3" || CaseSwitch == "4")
            {
                switch (CaseSwitch)
                {
                    case "1":

                        Console.WriteLine("Enter first Name: ");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Enter second Name: ");
                        string secondname = Console.ReadLine();

                        bool result = firstname.Equals(secondname, System.StringComparison.OrdinalIgnoreCase);
                        Console.WriteLine("Ordinal Comparison: {0} and {1} are {2}", firstname, secondname, result ? "equal. " : "not equal. ");
                        goto start;

                    case "2":
                        Console.WriteLine("Enter first name: ");
                        string thirdname = Console.ReadLine();
                        Console.WriteLine("Enter second name: ");
                        string fourthname = Console.ReadLine();
                        if (thirdname[0] == fourthname[0])
                        {
                            if (thirdname[thirdname.Length - 1] == fourthname[fourthname.Length - 1])
                            {
                                Console.WriteLine("First and last symbole are the same");
                            }

                        }
                        else
                        {
                            Console.WriteLine("First and last symbole not the same");
                        }
                        goto start;
                    case "3":
                        Console.WriteLine("Enter sentensce: /n");
                        string a = Console.ReadLine(), b = a.Replace("a", "u");
                        Console.WriteLine(b);
                    
                       
                        goto start;

                    case "4":
                        string[] input;

                        Console.Write("Enter string separated by commas and spaces (e.g. \"one, two, three\"): ");
                        input = Console.ReadLine().Split(", ");

                        Array.Sort(input, StringComparer.InvariantCultureIgnoreCase);

                        for (int i = 0; i < input.Length; i++)
                        {
                            if (i != input.Length - 1)
                            {
                                Console.Write($"{input[i]}, ");
                            }
                            else
                            {
                                Console.WriteLine($"{input[i]}.");
                            }
                            Console.ReadKey();
                        }


                        goto start;
                }
            }
            if (CaseSwitch != "1" || CaseSwitch != "2" || CaseSwitch != "3" || CaseSwitch != "4")
            {
                Console.WriteLine("Tri Again");
                goto start;
            }
        exit:;
        }
    }
}





