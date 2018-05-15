using System;
using System.Linq;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] testArr = new int[] {3, 2, 2, 3};
            var len = solution.RemoveElement(testArr, 3);
            
            testArr = new int[] {0,1,2,2,3,0,4,2};
            len = solution.RemoveElement(testArr, 2);
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            for (var j = 0; j<nums.Length; j++)
                if(nums[j] != val)
                    nums[i++] = nums[j];

            return i;
        }
    }
}
