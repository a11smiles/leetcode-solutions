using System;

namespace RemoveDuplicatesFromSortedArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] testArr = new int[] { 1, 1, 1, 2, 2, 3 };
            var len = solution.RemoveDuplicates(testArr);

            testArr = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            len = solution.RemoveDuplicates(testArr);
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            int max1 = Int32.MinValue;
            int max2 = Int32.MinValue;
            for (var j = 0; j < nums.Length; j++)
                if (nums[j] >= max1)
                {
                    nums[i++] = nums[j];
                    max1 = nums[j] + 1;
                }
                else if (nums[j] >= max2)
                {
                    nums[i++] = nums[j];
                    max2 = nums[j] + 1;
                }

            return i;
        }
    }
}
