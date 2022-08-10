using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai8
{
    class Program
    {
        public static void miniMaxSum(List<int> arr)
        {
            long sum1 = 0, sum2 = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            List<int> maxSum = new List<int>();
            List<int> minSum = new List<int>();
            max = arr.Max();
            min = arr.Min();
            for (int i = 0; i < arr.Count; i++)
            {
                maxSum.Add(arr[i]);
                minSum.Add(arr[i]);
            }
            maxSum.Remove(min);
            sum1 = maxSum.Sum();

            minSum.Remove(max);
            sum2 = minSum.Sum();
            Console.WriteLine(sum2 + " " + sum1);
        }

        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            miniMaxSum(arr);
        }
    }
}
