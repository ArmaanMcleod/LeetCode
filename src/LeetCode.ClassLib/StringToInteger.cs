using System;
using System.Text;

/*

Implement atoi which converts a string to an integer.

The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. 
Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

If no valid conversion could be performed, a zero value is returned.

Note:

Only the space character ' ' is considered as whitespace character.
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
If the numerical value is out of the range of representable values, INT_MAX (231 − 1) or INT_MIN (−231) is returned.

 */

namespace LeetCode.ClassLib {
    public class StringToInteger {

        /// <summary>
        /// Main solution for converting string to atoi number
        /// WARNING: VERY BAD CODE BELOW
        /// </summary>
        public int MyAtoi (string str) {
            string trimmed = str.Trim ();
            int length = trimmed.Length;

            for (int i = 0; i < length; i++) {
                if (trimmed[i] != ' ') {
                    string rest = trimmed.Substring (i, length - i);
                    int stringLength = rest.Length;
                    StringBuilder stringBuffer = new StringBuilder ();

                    if (rest[0] == '-' || rest[0] == '+') {
                        stringBuffer.Append (rest[0]);
                        rest = rest.Substring (1, stringLength - 1);
                    }

                    foreach (char character in rest) {
                        if (!Char.IsDigit (character)) {
                            break;
                        }
                        stringBuffer.Append (character);
                    }

                    try {
                        int number = Int32.Parse (stringBuffer.ToString ());
                        return number;

                    } catch (Exception ex) {
                        if (ex is OverflowException) {

                            if (stringBuffer[0] == '-') {
                                return int.MinValue;
                            }

                            return int.MaxValue;

                        } else if (ex is FormatException) {
                            return 0;
                        }
                    }

                }

                return 0;
            }

            return 0;
        }
    }
}