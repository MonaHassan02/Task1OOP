using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1OOPLibrary
{
    public struct Rectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine("Width cannot be negative");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    Console.WriteLine("Height cannot be negative");
            }
        }

        public double Area
        {
            get { return width * height; }
        }

        public Rectangle(double width, double height)
        {
            this.width = width >= 0 ? width : 0;
            this.height = height >= 0 ? height : 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Rectangle Dimensions:");
            Console.WriteLine($"Width: {Width} , Height: {Height} ,Area: {Area} ");
        }
    }
}
