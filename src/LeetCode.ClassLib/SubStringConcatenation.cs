using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/*

You are given a string, s, and a list of words, words, that are all of the same length. 
Find all starting indices of substring(s) in s that is a concatenation of each word in words exactly once and without any intervening characters.

Example 1:

Input:
  s = "barfoothefoobarman",
  words = ["foo","bar"]
Output: [0,9]
Explanation: Substrings starting at index 0 and 9 are "barfoor" and "foobar" respectively.
The output order does not matter, returning [9,0] is fine too.
Example 2:

Input:
  s = "wordgoodstudentgoodword",
  words = ["word","student"]
Output: []

 */

namespace LeetCode.ClassLib {
    public class SubStringConcatenation {

        /// <summary>
        /// Inneficient brute force solution.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="words"></param>
        /// <returns>THe indices of the correctly matches substrings</returns>
        public IList<int> FindSubstring (string s, string[] words) {
            IList<int> indices = new List<int> ();

            if (String.IsNullOrEmpty (s) || words.Length == 0 || !words.All (word => word.Length == words[0].Length)) {
                return indices;
            }

            IDictionary<string, int> wordCounts = new Dictionary<string, int> ();
            foreach (string word in words) {
                if (!wordCounts.ContainsKey (word)) {
                    wordCounts[word] = 0;
                }
                wordCounts[word] += 1;
            }

            string joinedStrings = String.Join ("", words);
            int length = joinedStrings.Length;

            for (int i = 0; i <= s.Length - length; i++) {
                string subString = s.Substring (i, length);
                int subStringLength = subString.Length;
                int chunkSize = words[0].Length;

                IDictionary<string, int> counts = new Dictionary<string, int> ();
                for (int j = 0; j < subStringLength; j += chunkSize) {
                    string chunk = subString.Substring (j, Math.Min (chunkSize, subStringLength - j));

                    if (!counts.ContainsKey (chunk)) {
                        counts[chunk] = 0;
                    }

                    counts[chunk] += 1;
                }

                bool valid = true;
                foreach (KeyValuePair<string, int> pair in wordCounts) {
                    if (!counts.ContainsKey (pair.Key)) {
                        valid = false;
                        break;
                    } else {
                        if (pair.Value != counts[pair.Key]) {
                            valid = false;
                            break;
                        }
                    }
                }

                if (valid) {
                    indices.Add (i);
                }

            }

            return indices;

        }
    }
}