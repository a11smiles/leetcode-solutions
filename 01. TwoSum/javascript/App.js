/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    var indexes;
    
    for (var i = 0; i < nums.length; i++) {
        for (var j = 0; j < nums.length; j++) {
            if (i != j) {
                if (nums[i] + nums[j] == target) 
                    indexes = [j, i];
            }
        }
    }
    
    return indexes;
};