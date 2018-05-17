using System;
using System.Linq;

namespace MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            nums1 = new int[] { 1, 2 };
            nums2 = new int[] { 3, 4 };
            result = solution.FindMedianSortedArrays(nums1, nums2);

            nums1 = new int[] { 4, 5, 6, 8, 9 };
            nums2 = new int[] { };
            result = solution.FindMedianSortedArrays(nums1, nums2);
        }
    }

    class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combined = nums1.Concat(nums2).ToArray();
            Array.Sort(combined);

            if (combined.Length % 2 == 0)
                return (combined[combined.Length / 2] + combined[combined.Length / 2 - 1]) / 2.0;
            else
                return combined[combined.Length / 2];
        }
    }
}
