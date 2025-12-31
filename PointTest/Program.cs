using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1OOPLibrary;


namespace PointTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X of first point: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y  of first point: ");
            double y1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter X  of second point: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y  of second point: ");
            double y2 = Convert.ToDouble(Console.ReadLine());


            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);

            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

            Console.WriteLine($"Point 1: ({point1.X}, {point1.Y})");
            Console.WriteLine($"Point 2: ({point2.X}, {point2.Y})");
            Console.WriteLine($"Distance between the points: {distance:F2}");

            {
                Console.WriteLine("enter valid values");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}