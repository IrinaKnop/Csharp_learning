using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива ");

            var s = Console.ReadLine();
            var arr = s.Split(' ');

            int[] list = new int[arr.Length];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = int.Parse(arr[i]);
            }

            int sum = ArrayUtils.SumAll(list);
            Console.WriteLine("Сумма элементов массива равна {0}", sum);

            double average = ArrayUtils.Average(list);
            Console.WriteLine("Среднее значение массива {0}", average);

            int[] negAndPosSums = ArrayUtils.NegativeAndPozitiveSums(list);
            Console.WriteLine("Сумма положительных эелементов массива равна {0} и сумма отрицательных элементов массива равна {1}", negAndPosSums[0], negAndPosSums[1]);

            int[] evenAndOddSums = ArrayUtils.EvenAndOddNumSums(list);
            Console.WriteLine("Сумма четных эелементов массива равна {0} и сумма нечетных элементов массива равна {1}", evenAndOddSums[0], evenAndOddSums[1]);

            int maxIndex = ArrayUtils.MaxIndex(list);
            int minIndex = ArrayUtils.MinIndex(list);
            Console.WriteLine("Индекс максимального элемента массива {0} и минимального элемента массива {1}", maxIndex, minIndex);

            int mult = ArrayUtils.Multiply(list);
            Console.WriteLine("Произведение элементов массива, расположенных между максимальным и минимальным элементами {0}", mult);



        }
    }
}
