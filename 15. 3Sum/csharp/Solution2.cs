// Quadratic algorithm
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Sum {
    public class Solution2
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i <= nums.Length - 2; i++) {
                var a = nums[i];
                var start = i + 1;
                var end = nums.Length - 1;

                while (start < end) {
                    var b = nums[start];
                    var c = nums[end];
                    if (a+b+c == 0) {
                        var result = new List<int> {a, b, c};
                        if (results.Count() == 0 || !results.Any(r => r.SequenceEqual(result)))
                            results.Add(result);
                    
                        if (b == nums[start + 1])
                            start += 1;
                        else    
                            end -= 1;
                    }
                    else if (a+b+c > 0) {
                        end -= 1;
                    }
                    else
                        start += 1;
                }
            }

            return results;
        }
    }
}