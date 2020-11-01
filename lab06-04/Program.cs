using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06_04
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
        }
    }
}
