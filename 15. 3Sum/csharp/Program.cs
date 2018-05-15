using System;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution1 = new Solution1();
            var solution2 = new Solution2();

            int[] testArr = new int[] {0,3,0,1,1,-1,-5,-5,3,-3,-3,0};
            var results = solution1.ThreeSum(testArr);
            results = solution2.ThreeSum(testArr);

            testArr = new int[] {-4,-2,-2,-2,0,1,2,2,2,3,3,4,4,6,6};
            results = solution1.ThreeSum(testArr);
            results = solution2.ThreeSum(testArr);

            testArr = new int[] {9,14,0,-8,10,0,2,9,-8,13,-3,1,10,-13,4,3,-3,-11,8,-13,-4,-6,5,-10,-14,0,3,-9,-9,-7,-11,8,-8,-4,-15,9,11,3,3,-11,-7,7,5,-12,1,-14,-1,13,-9,-8,7,2,-6,-11,-1,-5,-4,-13,-7,2,-13,-2,-5,-6,9,-12,10,-2,-2,-10,2,6,4,14,2,-10,-15,-14,10,-9,-15,-6,0,-6,-2,14,-3,9,8,-3,-12,10,2,-9,11,-3,-6,-2,10,7,3,-11,-10,-8,-12,-1};
            results = solution1.ThreeSum(testArr);
            results = solution2.ThreeSum(testArr);            
        }
    }
    
}
