using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape triangle = new Triangle(3, 4, 5);
            Console.WriteLine("Периметр треугольника " + triangle.Perimeter());
            Console.WriteLine("Площадь треугольника " + triangle.Area());
            triangle.Show();
            ((IRotatable)triangle).Rotate();

            Shape square = new Sqare(5);
            Console.WriteLine("Периметр квадрата " + square.Perimeter());
            Console.WriteLine("Площадь квадрата " + square.Area());
            square.Show();
            ((IRotatable)square).Rotate();

            Shape circle = new Circle(6);
            Console.WriteLine("Периметр окружности {0:F2}", circle.Perimeter());
            Console.WriteLine("Площадь круга {0:F2}", circle.Area());
            circle.Show();
        }
    }
}
