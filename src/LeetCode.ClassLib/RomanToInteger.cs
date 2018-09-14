using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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