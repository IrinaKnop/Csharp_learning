using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_04
{
    
    class Operation
    {
        private static bool IsTriangle(int a, int b, int c)
        {
            bool ok = false;
            if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
            {
                ok = true;
            }
            
            return ok;
        }
        public static double Area(int a, int b, int c)
        {
            double semiper = (double)(a + b + c) / 2;
            double area = -1;
            if (IsTriangle(a, b, c))
            {
                area = Math.Sqrt(semiper * (semiper - a) * (semiper - b) * (semiper - c)); 
            }
            return area;
        }
        public static double Area(int x)
        {
            double semiper = (double)x * 3 / 2;
            double area = Math.Sqrt(semiper * (semiper - x) * (semiper - x) * (semiper - x));
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numSide;
            double area = 0;
            Console.WriteLine("Площадь какого треугольника требуется расчитать? \nДля расчета площади равностороннего треугольника введите \"1\", \nдля расчета площади разностороннего треугольника введите \"3\". ");
            numSide = int.Parse(Console.ReadLine());

            if (numSide == 1)
            {
                Console.Write("Введите значение стороны равностороннего треугольника: ");
                int x = int.Parse(Console.ReadLine());

                area = Operation.Area(x);
            }
            else if (numSide == 3)
            {
                Console.Write("Введите значение стороны a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите значение стороны b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Введите значение стороны c: ");
                int c = int.Parse(Console.ReadLine());

                area = Operation.Area(a, b, c);
            }

            if (area != -1)
            {
                Console.WriteLine("Площадь треугольника равна {0:F2}", area);
            }
            else
            {
                Console.WriteLine("Это не треугольник.");
            }
        }
    }
}
