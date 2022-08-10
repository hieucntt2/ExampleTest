using System;

namespace Bai10
{
    class Program
    {
        public static string timeConversion(string s)
        {
            string res = "";
            string[] str = s.Split(':');

            if (s.EndsWith("PM") == true)
            {
                if (Convert.ToInt32(str[0]) < 12)
                {
                    //res = ((int.Parse(str[0]) + 12) + ":" + str[1] + ":" + str[2].Replace("PM", "")).ToString();
                    res = $"{int.Parse(str[0]) + 12}:{str[1]}:{str[2].Replace("PM", "")}";
                }
                else
                {
                    //res = s.Replace("PM", "");
                    res = $"{s.Replace("PM", "")}";
                }
            }
            else if (s.EndsWith("AM") == true)
            {
                if (Convert.ToInt32(str[0]) >= 12)
                {
                    //res = ((int.Parse(str[0]) - 12) + ":" + str[1] + ":" + str[2].Replace("AM", "")).ToString();
                    res = $"{int.Parse(str[0]) - 12}:{str[1]}:{str[2].Replace("AM", "")}";
                }
                else if (Convert.ToInt32(str[0]) == 12)
                {
                    //res = ("00:" + str[1] + ":" + str[2].Replace("AM", "")).ToString();
                    res = $"00:{str[1]}:{str[2].Replace("AM", "")}";
                }
                else
                {
                    //res = s.Replace("AM", "");
                    res = $"{s.Replace("AM", "")}";
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
