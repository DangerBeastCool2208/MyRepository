using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library
{
    public class Exponent
    {
        static object obj = new object();
       
        public static decimal Number(decimal prirost)
        {
            decimal num = 1;
            decimal i = 1;
            decimal j = ((1 / prirost) + 1);
            while (i < prirost)
            {
                num *= j;
                i++;
            }
            return num;
        }

        public static decimal NumberParallel(decimal prirost, int segment = 0)
        {
            if (segment == 0) segment = Environment.ProcessorCount;
            decimal num1, num2,number,chislo = 1;

            Task[] task = new Task[segment+1];
            num1 = Math.Round(prirost / segment);
            num2 = prirost % segment;
            number = (1 / prirost + 1);
            for (int iter = 0; iter <=segment-1;iter++)
            {
                task[iter] = new Task(() => NumberExpDiap(number, num1,ref chislo));
            }
            task[segment] = new Task(() => NumberExpDiap(number, num2, ref chislo)); 
            foreach (var t in task) t.Start();
            Task.WaitAll(task);
            return chislo;

        }
        

        private static void NumberExpDiap(decimal number, decimal iter,ref decimal num)
        {
            decimal num1 = 1;
            for (int i = 1; i <= iter; i++)
            {
                num1 *= number;
                
            }
            lock (obj)
            {
                num *= num1;
            }
        }







    }
}