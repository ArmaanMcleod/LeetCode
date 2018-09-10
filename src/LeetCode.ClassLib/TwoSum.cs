using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/*

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

 */

namespace LeetCode.ClassLib {

    /// <summary>
    /// This class is responsible for finding two numbers that equal a sum
    /// </summary>
    public class TwoSum {

        /// <summary>
        /// O(NLogN) sorting approach
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>A pair of indices</returns>
        public int[] FindTwoSumOne (int[] nums, int target) {
            int[] result = new int[2];

            // Form tuples of (number, index)
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>> ();
            for (int i = 0; i < nums.Length; i++) {
                pairs.Add (new Tuple<int, int> (nums[i], i));
            }

            // Sort tuples with respect to first element
            pairs.Sort ((x, y) => x.Item1.CompareTo (y.Item1));

            // Create bounds
            int start = 0;
            int end = pairs.Count - 1;

            // Main Loop where the magic happens
            while (start < end) {
                int sum = pairs.ElementAt (start).Item1 + pairs.ElementAt (end).Item1;

                // If sum is equal to target, were finished
                // Otherwise increment or decrement
                if (sum == target) {
                    result[0] = pairs.ElementAt (start).Item2;
                    result[1] = pairs.ElementAt (end).Item2;
                    Array.Sort (result);
                    break;
                } else if (sum < target) {
                    start++;
                } else {
                    end--;
                }
            }

            return result;

        }

        /// <summary>
        /// O(N) approach using a dictionary
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] FindTwoSumTwo (int[] nums, int target) {
            Dictionary<int, int> map = new Dictionary<int, int> ();
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++) {

                // Minus the current number off the target
                int complement = target - nums[i];

                // if complement exists, we have found a match
                if (map.ContainsKey (complement)) {
                    result[0] = map[complement];
                    result[1] = i;
                    break;
                }

                // To prevent key exception for adding the same key, remove it first
                map.Remove (nums[i]);
                map.Add (nums[i], i);
            }

            return result;
        }
    }
}