using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai6
{
    class Program
    {
        public static void plusMinus(List<int> arr)
        {
            float d = 0, d1 = 0, d0 = 0;
            int len = arr.Count;
            for(int i = 0; i < len; i++)
            {
                if (arr[i] > 0)
                    d1++;
                else if (arr[i] == 0)
                    d0++;
                else if (arr[i] < 0)
                    d++;
            }
            Console.WriteLine("{0:N6}" , d1 / len );
            Console.WriteLine("{0:N6}" , d / len );
            Console.WriteLine("{0:N6}" , d0 / len );
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            plusMinus(arr);
        }
    }
}
