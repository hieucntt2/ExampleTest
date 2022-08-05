using System;
using System.Collections.Generic;

namespace bai2
{
    class Program
    {
        public static int simpleArraySum(int n, int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] <= 1000)
                {
                    sum += arr[i];
                }
                else 
                    return 0;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int[] arr = new int[n];

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Nhap ptu {0}: ", i + 1);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Tong cac ptu: " + simpleArraySum(n, arr));

            }

        }
    }
}
