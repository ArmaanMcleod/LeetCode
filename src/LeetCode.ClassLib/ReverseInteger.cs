using System;

/*

Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

 */

namespace LeetCode.ClassLib {

    /// <summary>
    /// Straightforward solution that reverses the integer in string format
    /// </summary>
    public class ReverseInteger {

        /// <summary>
        /// Brute force reversal of integer using strings.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>The integer reversed</returns>
        public int Reverse (int x) {
            try {

                // First reverse the number as a string
                char[] characters = x.ToString ().ToCharArray ();
                Array.Reverse (characters);
                string reversedNumber = new string (characters);

                // Switch negative sign from end to front
                int length = reversedNumber.Length;
                if (reversedNumber[length - 1] == '-') {
                    reversedNumber = "-" + reversedNumber.Substring (0, length - 1);
                }

                return Int32.Parse (reversedNumber);
            } catch (OverflowException) {
                return 0;
            }

        }
    }
}