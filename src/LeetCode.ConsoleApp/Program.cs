using System;
using LeetCode.ClassLib;

namespace LeetCode.ConsoleApp {

    // This class is used to test answers from class lib
    class Program {
        public static void Main (string[] args) {
            TwoSumTest ();
            AddTwoTest ();
            LongestSubStringTest ();
            LongestPalindromeTest ();
        }

        /// <summary>
        /// Two Sum problem
        /// </summary>
        private static void TwoSumTest () {
            Console.WriteLine ("Two Sum question:");

            int[] testArray = { 3, 4, 2 };

            TwoSum twoSum = new TwoSum ();

            int[] result = twoSum.FindTwoSumTwo (testArray, 6);
            Console.WriteLine ("Result: [{0}, {1}]\n", result[0], result[1]);
        }

        /// <summary>
        /// Add Two problem
        /// Approach: reverse linked lists, concatenate elements to a single digit, then add them.
        /// TODO: Find a better solution
        /// </summary>
        private static void AddTwoTest () {
            Console.WriteLine ("Add two numbers question:");

            LinkedList l1 = new LinkedList ();
            l1.AddFront (l1, 2);
            l1.AddEnd (l1, 4);
            l1.AddEnd (l1, 3);
            l1.ReverseLinkedList (l1);
            int n1 = l1.GetNumber (l1);

            LinkedList l2 = new LinkedList ();
            l2.AddFront (l2, 5);
            l2.AddEnd (l2, 6);
            l2.AddEnd (l2, 4);
            l2.ReverseLinkedList (l2);
            int n2 = l2.GetNumber (l2);

            Console.WriteLine ("Result: {0} + {1} = {2}\n", n1, n2, n1 + n2);

        }

        /// <summary>
        /// Longest Substring problem
        /// </summary>
        private static void LongestSubStringTest () {
            Console.WriteLine ("Longest Substring question:");

            string[] testStrings = new string[] { "abcabcbb", "bbbbb", "pwwkew" };

            LongestSubString longestSubString = new LongestSubString ();

            Console.WriteLine ("Results:");
            foreach (string str in testStrings) {
                Console.WriteLine ("{0} -> {1}", str, longestSubString.LengthOfLongestSubstring (str));
            }

        }

        private static void LongestPalindromeTest () {
            Console.WriteLine ("\nLongest Palindrome question:");

            string[] testStrings = new string[] { "babad", "cbbd" };

            LongestPalindrome longestPalindrome = new LongestPalindrome ();

            Console.WriteLine ("Results:");
            foreach (string str in testStrings) {
                Console.WriteLine ("{0} -> {1}", str, longestPalindrome.LongestPalindromeSubStringTwo (str));
            }
        }
    }
}