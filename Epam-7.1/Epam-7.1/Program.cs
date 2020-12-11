using System;
using System.Collections.Generic;

namespace Epam_7._1
{
    class Per_son
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
        public Per_son(string name, int age, IEnumerable<string> phoneNumbers)
        {
            Name = name;
            Age = age;
            PhoneNumbers = phoneNumbers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Per_son> Person_List = new List<Per_son>
            {

                new Per_son("Valentine\n", 22, new List<string>() { "0672748296", "0698493765" }),
                new Per_son("Leonardo da Vinchi\n", 44, new List<string>() { "0443256797", "0969504367" }),
                new Per_son("Leonardo di Caprio\n", 51, new List<string>() { "0663859034", "0637589035" }),
                new Per_son("Lee\n", 33, new List<string>() { "0452384967", "0678953653" }),
                new Per_son("Eva Evil\n", 24, new List<string>() { "0732133321", "0941567430" })
            };

            foreach (var Per_son in Person_List)
            {
                Console.WriteLine("\n Person name: " + Per_son.Name + " " + " Person Age: " + Per_son.Age);
            }

            foreach (var item in Person_List)
            {
                Console.WriteLine("\n {0} phone numbers:", item.Name);
                foreach (var number in item.PhoneNumbers)
                {
                    Console.WriteLine("\t -{0}", number);
                }
            }
        }
    }
}

        
    
