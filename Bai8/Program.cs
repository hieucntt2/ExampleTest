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
            List<int> maxSum = arr.Select(x => x).ToList();
            List<int> minSum = arr.Select(x => x).ToList();
            max = arr.Max();
            min = arr.Min();
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
