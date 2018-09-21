using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/*

Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? 
Find all unique triplets in the array which gives the sum of zero.

Note:

The solution set must not contain duplicate triplets.

Example:

Given array nums = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]

 */
namespace LeetCode.ClassLib {
    public class ThreeSum {

        /// <summary>
        /// Quadratic solution using sorting and binary search.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>A nested list of solutions</returns>
        public IList<IList<int>> ThreeSumOne (int[] nums) {
            IList<IList<int>> sums = new List<IList<int>> ();
            HashSet<string> seen = new HashSet<string> ();

            int length = nums.Length;

            Array.Sort (nums);

            for (int i = 0; i < length - 2; i++) {
                int first = nums[i];

                int start = i + 1;
                int end = length - 1;
                while (start < end) {
                    int second = nums[start];
                    int third = nums[end];

                    int sum = first + second + third;
                    if (sum == 0) {
                        IList<int> triplet = new List<int> { first, second, third };
                        string stringHash = String.Join (",", triplet);

                        if (!seen.Contains (stringHash)) {
                            sums.Add (triplet);
                            seen.Add (stringHash);
                        }

                        start++;
                        end--;
                    } else if (sum > 0) {
                        end--;

                    } else {
                        start++;
                    }
                }
            }
            return sums;
        }
    }
}