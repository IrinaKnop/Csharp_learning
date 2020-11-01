using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09_05
{
    class Sqare : Shape, IRotatable
    {
        double side;

        public Sqare(double x)
        {
            side = x;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return side * 4;
        }

        public override void Show()
        {
            Console.WriteLine("Сторона квадрата равна " + side);
        }
        public void Rotate()
        {
            Console.WriteLine("Мы повернули квадрат"); 
        }

    }
}
