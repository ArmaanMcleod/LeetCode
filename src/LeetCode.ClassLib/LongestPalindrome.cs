using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        /// This does not pass the tests
        /// </summary>
        /// <param name="s"></param>
        /// <returns>longest palindrome</returns>
        public string LongestPalindromeSubStringOne (string s) {
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
        private static bool IsPalindrome (string s) {
            char[] charArray = s.ToCharArray ();
            Array.Reverse (charArray);
            string reversedString = new string (charArray);
            return s.Equals (reversedString);
        }

        /// <summary>
        /// Expands strings from center to find palindromes
        /// </summary>
        /// <param name="str"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <param name="palindromes"></param>
        private static string ExpandPalindrome (string str, int low, int high, string longestPalindrome) {
            int maxLength = longestPalindrome.Length;
            string longest = longestPalindrome;

            while (low >= 0 && high < str.Length && str[low] == str[high]) {
                int rest = high - low + 1;
                string subString = str.Substring (low, rest);
                int subStringLength = subString.Length;

                if (subStringLength > maxLength) {
                    maxLength = subStringLength;
                    longest = subString;
                }

                low--;
                high++;
            }

            return longest;
        }

        public string LongestPalindromeSubStringTwo (string s) {
            if (string.IsNullOrEmpty (s)) {
                return "";
            }

            HashSet<char> letters = new HashSet<char> (s.ToArray ());
            if (letters.Count == 1) {
                return s;
            }

            int length = s.Length;

            string longest = "";

            for (int i = 0; i < length; i++) {

                // Odd palindromes
                longest = ExpandPalindrome (s, i, i, longest);

                // Even palindromes
                longest = ExpandPalindrome (s, i, i + 1, longest);

            }

            return longest;
        }
    }
}