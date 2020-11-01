using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09_05
{
    class Circle : Shape
    {
        int radius;

        public Circle(int x)
        {
            radius = x;
        }

        public override double Area()
        {
            return radius * Math.PI * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override void Show()
        {
            Console.WriteLine("Радиус круга = " + radius);
        }
    }
}
