using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
However, the numeral for four is not IIII. 
Instead, the number four is written as IV. 
Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. 
There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given an integer, convert it to a roman numeral.
 Input is guaranteed to be within the range from 1 to 3999.

 */

namespace LeetCode.ClassLib {
    public class IntegerToRoman {
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
        /// Solution which goes through dictionary from highest to lowest, and sums the roman values.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Roman numeral in string form</returns>
        public string IntToRoman (int num) {
            StringBuilder buffer = new StringBuilder ();

            foreach (KeyValuePair<string, int> pair in map) {
                if (num == 0) {
                    return buffer.ToString ();
                }

                while (num >= pair.Value) {
                    buffer.Append (pair.Key);
                    num -= pair.Value;
                }
            }

            return buffer.ToString ();
        }
    }
}