using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/*

Given an array nums of n integers and an integer target, 
find three integers in nums such that the sum is closest to target. 
Return the sum of the three integers. 
You may assume that each input would have exactly one solution.

Example:

Given array nums = [-1, 2, 1, -4], and target = 1.

The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

 */

namespace LeetCode.ClassLib {
    public class ThreeSumClosest {

        /// <summary>
        /// Quadratic solution to problem
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>The closest target sum</returns>
        public int ThreeSumClosestOne (int[] nums, int target) {
            int length = nums.Length;

            int result = nums[0] + nums[1] + nums[length - 1];

            if (length == 3) {
                return result;
            }

            Array.Sort (nums);

            for (int i = 0; i < length - 2; i++) {
                int start = i + 1;
                int end = length - 1;

                while (start < end) {

                    int sum = nums[i] + nums[start] + nums[end];

                    if (sum > target) {
                        end--;

                    } else {
                        start++;
                    }

                    if (Math.Abs (sum - target) < Math.Abs (result - target)) {
                        result = sum;
                    }
                }
            }
            return result;
        }
    }
}