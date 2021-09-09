using System;
using Library;

namespace ProgramExponent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Прогон для получения числа Эйлера
            Console.WriteLine();
            decimal i = 900000000;
            Console.WriteLine(Environment.ProcessorCount + "\n");
                Console.WriteLine($"Степень прогона: {i}");
                Console.WriteLine($"Число эйлера: {Exponent.NumberParallel(i)}\n");
                
            
        }


    }
}
