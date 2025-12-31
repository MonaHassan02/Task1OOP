using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task1OOPLibrary;
namespace PersonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Person Details ----");

            Person[] persons = new Person[3];

            persons[0] = new Person("Lina", 29);
            persons[1] = new Person("Nasser", 24);
            persons[2] = new Person("Samira", 32);

            Console.WriteLine("\nPerson Details:");

            foreach (var p in persons)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
