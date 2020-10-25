using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение периметра треугольника");
            double semiper = (double.Parse(Console.ReadLine())) / 2;

            double side = semiper * 2 / 3;
            double area = Math.Sqrt(semiper * (semiper - side) * (semiper - side) * (semiper - side));

            Console.WriteLine("\tСторона \tПлощадь \n\t{0:F2} \t\t{1:F2}", side, area);
        }
    }
}
