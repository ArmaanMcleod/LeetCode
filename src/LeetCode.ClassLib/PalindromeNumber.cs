using System;

namespace LeetCode.ClassLib {
    public class PalindromeNumber {
        public bool IsPalindrome (int x) {
            char[] charArray = x.ToString ().ToCharArray ();
            Array.Reverse (charArray);
            string reversedString = new string (charArray);
            return reversedString.Equals (x.ToString ());
        }
    }
}