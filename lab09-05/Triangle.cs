using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09_05
{
    class Triangle : Shape, IRotatable
    {
        private int sideA;
        private int sideB;
        private int sideC;

        public Triangle(int a, int b, int c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public Triangle(int a)
        {
            sideA = a;
            sideB = a;
            sideC = a;
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override double Area()
        {
            double semiper = (double)Perimeter() / 2;
            double area = -1;
            if (IsTriangle())
            {
                area = Math.Sqrt(semiper * (semiper - sideA) * (semiper - sideB) * (semiper - sideC));
            }
            return area;
        }

        public bool IsTriangle()
        {
            bool ok = false;
            if (((sideA + sideB) > sideC) && ((sideA + sideC) > sideB) && ((sideB + sideC) > sideA))
            {
                ok = true;
            }

            return ok;
        }

        public override void Show()
        {
            Console.WriteLine ("Сторона треугольника а = " + sideA + "; Сторона b = " + sideB + "; Сторона с = " + sideC);
        }

        public void Rotate()
        {
            Console.WriteLine("Мы повернули треугольник");
        }

         
    }
}
