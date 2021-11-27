using System.Text;
using System;
using System.Collections.Generic;

namespace MyLibrary_dll.MyMath
{
    public class PrimeNumber
    {
        public List<int> PrimeDecomposition(int num)
        {
            var list = new List<int>();
            while (true)
            {
                var slog = Decomposition(num);
                if (num == slog)
                {
                    list.Add(slog);
                    break;
                }
                else
                {
                    num = num / slog;
                    list.Add(slog);
                }
            }
            //list.Add(1);
            return list;
        }

        public string PrimeDecompositionString(int num)
        {
            StringBuilder stroka = new StringBuilder();
            var list = PrimeDecomposition(num);
            int count = list.Count;
            int i = 0;
            foreach (int str in list)
            {
                stroka.Append(str);
                i++;
                if (i != count)
                {
                    stroka.Append(" x ");
                }
            }
            return stroka.ToString();
        }

        private int Decomposition(int num)
        {
            for (int i = 2; i <= num; i++)
            {
                if ((num % i) == 0) return i;
            }
         return 1;
        }
    }
}