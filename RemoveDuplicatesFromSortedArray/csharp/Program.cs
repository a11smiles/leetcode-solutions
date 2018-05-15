using System;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] testArr = new int[] {1,1,2};
            var len = solution.RemoveDuplicates(testArr);
            
            testArr = new int[] {0,0,1,1,1,2,2,3,3,4};
            len = solution.RemoveDuplicates(testArr);
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            int max = Int32.MinValue;
            for(var j = 0; j<nums.Length; j++)
                if (nums[j] >= max) {
                    nums[i++] = nums[j];
                    max = nums[j] + 1;
                }

            return i;
        }
    }
}
