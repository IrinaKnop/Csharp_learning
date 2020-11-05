using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance d1 = new Distance(6, 3);
            Distance d2 = new Distance(1, 11);

            Distance d3 = d1 + d2;
            Distance d4 = d1 - d2;

            Console.WriteLine("Величина 1 равна {0}, величина 2 равна {1}", d1, d2);

            Console.WriteLine("Результат сложения " + d3);
            Console.WriteLine("Результат вычитания " + d4);

            if (d1 > d2)
            {
                Console.WriteLine("Величина {0} больше", d1);
            }
            else if (d1 < d2)
            {
                Console.WriteLine("Величина {0} больше", d2);
            }
            else
            {
                Console.WriteLine("Величины равны");
            }
        }
    }
}
