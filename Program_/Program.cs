using System;

namespace Program_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                //Console.WriteLine($"Число n={i}, Числитель = {Chisl(i)}, Знаменатель = {Znam(i)}");
                // Console.WriteLine($"Частное = {(double)Chisl(i) / Znam(i)}, больше 1 ?: {(double)Chisl(i) / Znam(i) > 1}\n");
                //Console.WriteLine($"Порядок суммы: {i}");
                //Console.WriteLine($"Функция 1: {Rav1(i)}, Функция 2: {Rav2(i)}");
                //Console.WriteLine($"Функция 1 > Функция 2 : {Rav1(i)> Rav2(i)}\n");
                Console.WriteLine($"Экспонента в степени 0.25 = {Exp(0.25)}");
            }
            Console.WriteLine("Hello World!");
        }

        public static int Znam(int n)
        {
            int num = 0;
            num = Step(n, 5) + 5 * Step(n, 4) + 3 * n + 15;
            return num;
        }

        public static int Chisl(int n)
        {
            int num = 0;
            num = 8*(Step(n, 4) + 4 * Step(n, 3) + 6 * n * n + 4 * n + 1) + 24;
            return num;
        }

        public static  int Step(int x, int step)
        {
            int num = x;
            for (int i = 1; i < step; i++)
            {
                num *= x;
            }
            return num;
        }

        public static decimal Rav1(int n)
        {
            return n * (decimal)Math.Sin((double)1/(n*n));
        }

        public static decimal Rav2(int n)
        {
            return (n +1) * (decimal)Math.Sin((double)1 / ((n + 1) * (n + 1)));
        }

        static double Exp(double x)
        {
            double an = 1;
            double sum = 0;

            for (int n = 0; ; n++)
            {
                sum += an;
                an = x / (n + 1) * an;

                if (an < Double.Epsilon)
                    break;
            }

            return sum;
        }
    }


}
