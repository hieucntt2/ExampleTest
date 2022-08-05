using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bai3
{
    class Program
    {
        public static List<int> compareTriplets(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            int d1 = 0, d2 = 0;

            for(int i=0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                    d1++;
                else if (a[i] < b[i])
                    d2++;
            }
            result.Add(d1);
            result.Add(d2);
            return result;

        }
        static void Main(string[] args)
        {
            int n;

            n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            Console.WriteLine("Alice:");
            for(int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Bob :");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> a = compareTriplets(arr1, arr2);
            for (int i=0; i< a.Count; i++)
            {
                Console.Write(a[i] + " ");
            }


        }
    }
}
