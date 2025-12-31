using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1OOPLibrary;

namespace RectangleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Rectangle Task ---");

            Rectangle rectangle = new Rectangle();

            Console.WriteLine(" rectangle dimensions:");

            Console.Write("Enter width: ");
            rectangle.Width = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            rectangle.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("---Testing with negative values---");
            rectangle.Width = -5; 
            rectangle.Height = -3;

            Console.WriteLine("---Final Rectangle Info---");
            rectangle.DisplayInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
