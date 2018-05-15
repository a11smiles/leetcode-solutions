using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.IsPalindrome(121));
            Console.WriteLine(solution.IsPalindrome(-121));
            Console.WriteLine(solution.IsPalindrome(10));
        }
    }

    class Solution {

        public bool IsPalindrome(int x)
        {
            return x.ToString() == Reverse(x.ToString());
        }

        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
