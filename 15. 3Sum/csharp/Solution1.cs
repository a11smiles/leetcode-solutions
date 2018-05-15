// Straight-forward approach
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Sum {
    public class Solution1
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();
            Array.Sort(nums);

            for(int i = 0; i<nums.Length - 2; i++) 
                for(int j = i + 1; j<nums.Length - 1; j++) 
                    for(int k = j + 1; k<nums.Length; k++)
                        if (nums[i] + nums[j] + nums[k] == 0) {
                            List<int> result = new List<int> { nums[i], nums[j], nums[k]};

                            if (results.Count() == 0 || !results.Any(r => r.SequenceEqual(result)))
                                results.Add(result);
                        }

            return results;
        }
    }
}