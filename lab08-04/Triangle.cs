﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08_04
{
    class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }
        public Triangle(double a)
        {
            sideA = a;
            sideB = a;
            sideC = a;
        }

        public double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public double Area()
        {
            double semiper = Perimeter() / 2;
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

        public override string ToString()
        {
            return "Сторона а = " + sideA + "; Сторона b = " + sideB + "; Сторона с = " + sideC;
        }
    }
}
