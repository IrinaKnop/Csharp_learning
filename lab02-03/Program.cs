using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02_03
{
    public struct Distance
    {
        public int foot;
        public double inch;

        public int SetFoot(int n)
        {
            Console.Write("Введите футы для {0}-й переменной ", n);
            foot = int.Parse(Console.ReadLine());
            return foot;
        }
        public double SetInch(int n)
        {
            Console.Write("Введите дюймы для {0}-й переменной ", n);
            inch = double.Parse(Console.ReadLine());
            return inch;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();

            d1.foot = d1.SetFoot(1);
            d1.inch = d1.SetInch(1);

            d2.foot = d2.SetFoot(2);
            d2.inch = d2.SetInch(2);

            Distance d3 = new Distance();
            d3.foot = d1.foot + d2.foot + ((int)((d1.inch + d2.inch) / 12));
            d3.inch = (d1.inch + d2.inch) % 12;

            Console.WriteLine("Результат сложения равен {0}\'-{1}\"", d3.foot, d3.inch);
        }
    }
}
