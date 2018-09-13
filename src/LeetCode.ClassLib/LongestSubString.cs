using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

Given a string, find the length of the longest substring without repeating characters.

Example 1:

Input: "abcabcbb"
Output: 3 
Explanation: The answer is "abc", with the length of 3. 
Example 2:

Input: "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3. 
             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

 */

namespace LeetCode.ClassLib {

    /// <summary>
    /// Quadratic solution to longest substring problem 
    /// </summary>
    public class LongestSubString {
        public int LengthOfLongestSubstring (string s) {
            int length = s.Length;
            int maxLength = 0;

            // Loop over the start characters
            for (int i = 0; i < length; i++) {
                HashSet<char> seen = new HashSet<char> { s[i] };

                int count = 1;

                // Loop over rest of characters
                for (int j = i + 1; j < length; j++) {
                    char character = s[j];

                    // If characters has already been seen, were finished
                    if (seen.Contains (character)) {
                        break;
                    }

                    count++;
                    seen.Add (character);
                }

                if (count > maxLength) {
                    maxLength = count;
                }
            }

            return maxLength;
        }
    }
}