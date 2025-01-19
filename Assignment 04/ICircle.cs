using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    public interface ICircle : IShape
    {
        int Radius { get; set; }

    }

    class Circle : ICircle
    {
        int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        int ICircle.Radius { get; set; }


        public double Area()
        {
            return Math.PI *Radius*Radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius={Radius} , Area={Area()}");
        }
    }
}
