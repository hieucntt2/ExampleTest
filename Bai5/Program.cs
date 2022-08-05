using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai5
{
    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sum1 = 0, sum2 = 0;
            for(int i=0; i < arr.Count; i++)
            {
                sum1 += arr[i][i];
                sum2 += arr[i][arr.Count-1-i];
            }
            return Math.Abs(sum1-sum2);
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);

        }
    }
}
