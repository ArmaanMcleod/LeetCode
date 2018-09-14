using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, two is written as II in Roman numeral, just two one's added together. 
Twelve is written as, XII, which is simply X + II. 
The number twenty seven is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. 
However, the numeral for four is not IIII. Instead, the number four is written as IV. 
Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. 
There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.

 */

namespace LeetCode.ClassLib {
    public class RomanToInteger {

        // Create single roman numerals
        private static Dictionary<string, int> singleRomans = new Dictionary<string, int> () { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 } };

        // Create double roman numerals
        private static Dictionary<string, int> doubleRomans = new Dictionary<string, int> () { { "IV", 4 }, { "IX", 9 }, { "XL", 40 }, { "XC", 90 }, { "CD", 400 }, { "CM", 900 } };

        /// <summary>
        /// Created brute force solution.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Roman numeral in integer form</returns>
        public int RomanToInt (string s) {
            int number = 0;

            // First count up the double romans
            foreach (KeyValuePair<string, int> pair in doubleRomans) {
                int matches = Regex.Matches (s, pair.Key).Count;

                // If match found, sum them and remove the substrings
                if (matches > 0) {
                    number += pair.Value * matches;
                    s = s.Replace (pair.Key, "");
                }
            }

            // Second count up the remaining single romans
            foreach (KeyValuePair<string, int> pair in singleRomans) {
                int matches = Regex.Matches (s, pair.Key).Count;
                number += pair.Value * matches;
            }

            return number;
        }
    }
}