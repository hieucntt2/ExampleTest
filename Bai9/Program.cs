using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai9
{
    class Program
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int d = 0;
            int max = int.MinValue;
            //max = candles.OrderByDescending(x => x).First();
            max = candles.Max();
            d = candles.Count(x => x == max);
            return d;
        }
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);
            Console.WriteLine(result);
        }
    }
}
