using System;
using System.Text;

/*

Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

Example 1:

Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:

Input: "cbbd"
Output: "bb"

 */

namespace LeetCode.ClassLib {
    public class LongestPalindrome {

        /// <summary>
        /// Brute force finding longest palindrome
        /// </summary>
        /// <param name="s"></param>
        /// <returns>longest palindrome</returns>
        public string LongestPalindromeSubString (string s) {
            if (string.IsNullOrEmpty (s)) {
                return "";
            }

            int length = s.Length;
            int maxLength = 1;
            String longestSubstring = s.Substring (0, 1);

            for (int i = 0; i < length; i++) {
                int rest = s.Length - i + 1;

                for (int j = 2; j < rest; j++) {
                    string subString = s.Substring (i, j);

                    if (IsPalindrome (subString)) {
                        int subStringLength = subString.Length;

                        if (subStringLength > maxLength) {
                            maxLength = subStringLength;
                            longestSubstring = subString;
                        }
                    }

                }
            }

            return longestSubstring;

        }

        /// <summary>
        /// Determines if string is a palindrome
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool IsPalindrome (string s) {
            char[] charArray = s.ToCharArray ();
            Array.Reverse (charArray);
            string reversedString = new string (charArray);
            return s.Equals (reversedString);
        }
    }
}