using System;

namespace ReverseInteger
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.Reverse(123));
            Console.WriteLine(solution.Reverse(-123));
            Console.WriteLine(solution.Reverse(120));
        }

    }

    class Solution {
        public int Reverse(int x)
        {
            bool neg = (x < 0);

            try
            {
                x = Math.Abs(x);

                return neg ? Convert.ToInt32(Reverse(x.ToString())) * -1 : Convert.ToInt32(Reverse(x.ToString()));
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
