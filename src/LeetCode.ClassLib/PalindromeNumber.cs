using System;

/*

Determine whether an integer is a palindrome. 
An integer is a palindrome when it reads the same backward as forward.

Example 1:

Input: 121
Output: true
Example 2:

Input: -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. 
Therefore it is not a palindrome.
Example 3:

Input: 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
Follow up:

Coud you solve it without converting the integer to a string?

 */

namespace LeetCode.ClassLib {
    public class PalindromeNumber {

        /// <summary>
        /// Easy solution using Strings.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Boolean indicating if number is palindrome</returns>
        public bool IsPalindromeOne (int x) {
            char[] charArray = x.ToString ().ToCharArray ();
            Array.Reverse (charArray);
            string reversedString = new string (charArray);
            return reversedString.Equals (x.ToString ());
        }

        /// <summary>
        /// Reverses a number
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Reversed integer</returns>
        private static int reverseNumber (int x) {
            int revertedNumber = 0;

            while (x != 0) {
                int remainder = x % 10;
                revertedNumber = revertedNumber * 10 + remainder;
                x /= 10;
            }

            return revertedNumber;
        }

        /// <summary>
        /// Second solution without converting number to string
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Boolean indicating if number is palindrome</returns>
        public bool IsPalindromeTwo (int x) {
            if (x < 0 || (x % 10 == 0 && x != 0)) {
                return false;
            }

            int reversedNumber = reverseNumber (x);

            return x == reversedNumber;

        }
    }
}