using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_05
{
    class Program
    {
        static int CalcRoots(int a, int b, int c, out double x1, out double x2)
        {
            int i = 0;
            x1 = 0;
            x2 = 0;

            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                i = 1;
                return i;
            }
            else if (d == 0)
            {
                x1 = x2 = -b / (2 * a);
                i = 0;
                return i;
            }
            else
            {
                i = -1;
                return i;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры квадратного уравнения вида a*x^2 + b*x + c = 0");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            int i = CalcRoots(a, b, c, out double x1, out double x2);

            if (i > 0)
            {
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны: x1 = {3}, x2 = {4}.", a, b, c, x1, x2);
            }
            else if (i == 0) {
                Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} один: x1 = x2 = {3}.", a, b, c, x1);
            }
            else
            {
                Console.WriteLine("Действительных корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.", a, b, c);
            }
        }
    }
}
