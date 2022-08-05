using System;

namespace Bai7
{
    class Program
    {
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String(' ', n - i) + new String('#', i));
            }
        }


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            staircase(n);
        }
    }
}
