using System;
using System.Text;

namespace LeetCode.ClassLib {
    public class StringToInteger {

        /// <summary>
        /// Main solution for converting string to atoi number
        /// Some unnecessary and useless code here and could be refactored more 
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

                    // Attempt to return a valid integer
                    try {
                        int number = Int32.Parse (stringBuffer.ToString ());
                        return number;

                        // Handle exceptions
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