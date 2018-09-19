using System;
using System.Linq;
using System.Text;

namespace LeetCode.ClassLib {
    public class LongestCommonPrefix {
        public string LongestCommonPrefixOne (string[] strs) {
            StringBuilder commonPrefix = new StringBuilder ();

            // If array is empty, just return empty string
            // Otherwise you can handle exceptions
            if (strs == null || strs.Length == 0) {
                return commonPrefix.ToString ();
            }

            // First get the shortest length in the array
            int shortestLength = strs.Min (w => w.Length);

            for (int i = 0; i < shortestLength; i++) {
                char firstLetter = strs[0][i];

                // If all characters are the same, keep going
                if (!strs.All (w => w[i] == firstLetter)) {
                    break;
                }
                commonPrefix.Append (firstLetter);
            }

            return commonPrefix.ToString ();

        }
    }
}