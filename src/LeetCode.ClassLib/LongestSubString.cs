using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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