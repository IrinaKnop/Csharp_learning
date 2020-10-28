using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05_03
{
    class ArrayUtils
    {
        public static int SumAll(int[] arr)
        {
            int sum = 0;
            foreach(int a in arr)
            {
                sum += a;
            }
            return sum;
            
        }

        public static double Average(int[] arr)
        {
            double result = (double)SumAll(arr) / arr.Length;
            return result;
        }

        public static int[] NegativeAndPozitiveSums(int[] arr)
        {
            int pos = 0;
            int neg = 0;
            foreach(int a in arr)
            {
                if (a > 0)
                {
                    pos += a;
                }
                else if (a < 0)
                {
                    neg += a;
                }
            }
            int[] result = { pos, neg };
            return result;
        }

        public static int[] EvenAndOddNumSums(int[] arr)
        {
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2 == 0)
                {
                    even += arr[i];
                }
                else
                {
                    odd += arr[i];
                }
            }
            int[] result = { even, odd };
            return result;
        }

        public static int MaxIndex(int[] arr)
        {
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            return index;
        }

        public static int MinIndex(int[] arr)
        {
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }
            return index;
        }

        public static int Multiply(int[] arr)
        {
            int minIdex = MinIndex(arr);
            int maxIndex = MaxIndex(arr);
            int start;
            int stop;
            int result = 1;

            if (minIdex < maxIndex)
            {
                start = minIdex + 1;
                stop = maxIndex;
            }
            else
            {
                start = maxIndex + 1;
                stop = minIdex;
            }

            for (int i = start; i < stop; i++)
            {
                result *= arr[i];
            }
            return result;
        }
    }
}
