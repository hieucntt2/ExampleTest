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
            for (int i = 0; i < arr.Count ; i++)
            {
                maxSum.Add(arr[i]);
                minSum.Add(arr[i]);
                min = Math.Min(arr[i], min);
                max = Math.Max(arr[i], max);
            }
            maxSum.Remove(min);
            for (int i = 0; i < maxSum.Count; i++)
            {
                sum1 += maxSum[i];
            }

            minSum.Remove(max);
            for (int i = 0; i < minSum.Count; i++)
            {
                sum2 += minSum[i];
            }
            Console.WriteLine(sum2 + " " + sum1);

        }

        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            miniMaxSum(arr);

        }
    }
}
