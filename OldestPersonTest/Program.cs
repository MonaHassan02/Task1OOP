
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task1OOPLibrary;

namespace OldestPersonTest
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" ---- Oldest Person ---- ");

            Person[] persons = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" Enter details for Person {i + 1}:");
                Console.Write("Name: ");

                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                persons[i] = new Person(name, age);
            }

            Person oldest = persons[0];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldest.Age)
                {
                    oldest = persons[i];
                }
            }

            Console.WriteLine($" Oldest Person: {oldest.Name}, Age: {oldest.Age}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
