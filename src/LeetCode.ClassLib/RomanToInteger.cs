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

        private static Dictionary<string, int> map = new Dictionary<string, int> { { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 }
        };

        /// <summary>
        /// Created brute force solution.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Roman numeral in integer form</returns>
        public int RomanToInt (string s) {
            int number = 0;

            while (!String.IsNullOrEmpty (s)) {
                if (s.Length == 1) {
                    number += map[s];
                    return number;
                }

                string nextTwo = s.Substring (0, 2);
                if (map.ContainsKey (nextTwo)) {
                    number += map[nextTwo];
                    s = s.Substring (2);
                } else {
                    string singleChar = s.Substring (0, 1);
                    number += map[singleChar];
                    s = s.Substring (1);
                }
            }

            return number;
        }
    }
}