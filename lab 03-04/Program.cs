using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_04
{
    class Shooter
    {
        private int score = 0;

        public int Shoot(Point target, Point bang)
        {
            double range = Math.Sqrt(Math.Pow(target.x - bang.x, 2) + Math.Pow(target.y - bang.y, 2));
            int shootScore = (int)(10 - range);
            score += shootScore;
            Console.WriteLine("Ваш счет при выстреле: {0}", shootScore);
            return score;
        }

        public int GetScore() => this.score;

    }
    class Point {
        public int x;
        public int y;
        Random rnd = new Random();
        public Point()
        {
            x = rnd.Next(0, 10);
            y = rnd.Next(0, 10);
        }
        Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Point SetBang()
        {
            string[] nums_strings = Console.ReadLine().Split();
            int[] nums = new int[nums_strings.Length];
            for (int i = 0; i < nums_strings.Length; i++)
                nums[i] = Convert.ToInt32(nums_strings[i]);
            int x = nums[0];
            int y = nums[1];
            Point p = new Point(x, y);
            return p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";
            Shooter shooter = new Shooter();

            while (answer == "y")
            {
                Console.Write("Введите координаты выстрела (от 0 до 10) ");
                Point bang = Point.SetBang();
                Point target = new Point();

                shooter.Shoot(target, bang);
                Console.WriteLine("Мишень была в точке {0} {1}", target.x, target.y);
            
                Console.Write("Хотите сделать еще один выстрел? (y / n) ");
                answer = Console.ReadLine();

                if ((answer != "y") && (answer != "n"))
                {
                    while ((answer != "y") && (answer != "n"))
                    {
                        Console.Write("Введите один из предложенных ответов (y - \"да\" / n - \"нет\") ");
                        answer = Console.ReadLine();
                    }
                }
                else if (answer == "n")
                {
                    break;
                }
            }

            Console.WriteLine("Ваш счет: {0}", shooter.GetScore());
            
        }
    }
}
