using System;
using Library;

namespace ProgramExponent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Прогон для получения числа Эйлера
            Console.WriteLine(Library.Exponent.Exp);
            for (long i = 1; i < 10000000; i *=10)
            {
                Console.WriteLine($"Степень прогона: {i}");
                Console.WriteLine($"Число эйлера: {Library.Exponent.Number(i)}\n");
                
            }
        }
    }
}
