using System;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            string str = "III";
            var value = solution.RomanToInt(str);

            str = "IV";
            value = solution.RomanToInt(str);

            str = "IX";
            value = solution.RomanToInt(str);

            str = "LVIII";
            value = solution.RomanToInt(str);

            str = "MCMXCIV";
            value = solution.RomanToInt(str);
        }

    }

    public class Solution
    {

        public int RomanToInt(string s)
        {
            char[] charArray = s.ToCharArray();

            int value = 0;
            var prev = 0;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {

                int curValue = charArray[i] == 'I' ? 1 :
                            charArray[i] == 'V' ? 5 :
                            charArray[i] == 'X' ? 10 :
                            charArray[i] == 'L' ? 50 :
                            charArray[i] == 'C' ? 100 :
                            charArray[i] == 'D' ? 500 :
                            charArray[i] == 'M' ? 1000 : 0;

                if (curValue < prev)
                    value -= curValue;
                else
                    value += curValue;

                prev = curValue;
            }

            return value;
        }
    }
}
