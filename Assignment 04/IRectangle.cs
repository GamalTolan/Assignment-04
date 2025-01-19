using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    public interface IRectangle :IShape
    {
        int Width { get; set; }
        int Length { get; set; }

    }

    class Rectangle : IRectangle
    {
        public int Width { get ; set; }
        public int Length { get ; set ; }

        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public double Area()
        {
            return Width* Length;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($" Width={Width} , length ={Length} , Area = {Area()}");
        }
    }


}
