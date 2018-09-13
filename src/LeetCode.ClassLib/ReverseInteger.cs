using System;

namespace LeetCode.ClassLib {

    /// <summary>
    /// Straightforward solution that reverses the integer in string format
    /// </summary>
    public class ReverseInteger {
        public int Reverse (int x) {
            try {

                // First reverse the number as a string
                char[] characters = x.ToString ().ToCharArray ();
                Array.Reverse (characters);
                string reversedNumber = new string (characters);

                // Switch negative sign from end to front
                int length = reversedNumber.Length;
                if (reversedNumber[length - 1] == '-') {
                    reversedNumber = "-" + reversedNumber.Substring (0, length - 1);
                }

                return Int32.Parse (reversedNumber);
            } catch (OverflowException) {
                return 0;
            }

        }
    }
}