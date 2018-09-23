using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/*

Given a string containing digits from 2-9 inclusive, 
return all possible letter combinations that the number could represent.

A mapping of digit to letters (just like on the telephone buttons) is given below. 
Note that 1 does not map to any letters.



Example:

Input: "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
Note:

Although the above answer is in lexicographical order, 
your answer could be in any order you want.

 */

namespace LeetCode.ClassLib {
    public class LetterCombinations {
        private static IDictionary<char, string> map = new Dictionary<char, string> { { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        /// <summary>
        /// Naive approach to finding all substring combinations.
        /// Behaves simuilarily to a cartesian product.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public IList<string> LetterCombinationsOne (string digits) {
            List<string> combinations = new List<string> ();

            // Base case
            if (String.IsNullOrEmpty (digits)) {
                return combinations;
            }

            // Initiall empty combination
            combinations.Add ("");

            foreach (char digit in digits) {
                List<string> result = new List<string> ();

                foreach (char letter in map[digit]) {
                    foreach (string comb in combinations) {
                        result.Add (comb + letter);
                    }
                }

                combinations = result;
            }

            // Sort lexographically at the end
            combinations.Sort ();

            return combinations;
        }
    }
}