using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Console.WriteLine("Это трегольник? " + triangle.IsTriangle());
            Console.WriteLine("Периметр треугольника " + triangle.Perimeter());
            Console.WriteLine("Площадь треугольника " + triangle.Area());
            Console.WriteLine(triangle.ToString());

            Triangle equalSidesTriangle = new Triangle(5);

            Console.WriteLine("Это трегольник? " + equalSidesTriangle.IsTriangle());
            Console.WriteLine("Периметр треугольника " + equalSidesTriangle.Perimeter());
            Console.WriteLine("Площадь треугольника " + equalSidesTriangle.Area());
            Console.WriteLine(equalSidesTriangle.ToString());
        }
    }
}
