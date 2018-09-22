using System;
using System.Collections;
using System.Collections.Generic;
using LeetCode.ClassLib;

namespace LeetCode.ConsoleApp {

    // This class is used to test answers from class lib
    class Program {
        public static void Main (string[] args) {
            TwoSumTest ();
            AddTwoTest ();
            LongestSubStringTest ();
            LongestPalindromeTest ();
            ReverseIntegerTest ();
            StringToIntegerTest ();
            PalindromeNumberTest ();
            RomanToIntegerTest ();
            IntegerToRomanTest ();
            LongestCommonPrefixTest ();
            ThreeSumTest ();
            ThreeSumClosestTest ();
            LetterCombinationsTest ();
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

        private static void ReverseIntegerTest () {
            Console.WriteLine ("\nReverse Integer question:");

            int[] testNumbers = new int[] { 123, -123, 120, 1534236469 };

            ReverseInteger reverseInteger = new ReverseInteger ();

            foreach (int number in testNumbers) {
                Console.WriteLine ("{0} -> {1}", number, reverseInteger.Reverse (number));
            }
        }

        private static void StringToIntegerTest () {
            Console.WriteLine ("\nReverse Integer question:");

            string[] testStrings = new string[] { "42", "   -42", "4193 with words", "words and 987", "-91283472332", "+1", "2147483648" };

            StringToInteger stringToInteger = new StringToInteger ();

            foreach (string str in testStrings) {
                Console.WriteLine ("{0} -> {1}", str, stringToInteger.MyAtoi (str));
            }
        }

        private static void PalindromeNumberTest () {
            Console.WriteLine ("\nPalindrome Number question:");

            PalindromeNumber palindromeNumber = new PalindromeNumber ();

            int[] testNumbers = new [] { 121, -121, 10 };

            foreach (int number in testNumbers) {
                Console.WriteLine ("{0} -> {1}", number, palindromeNumber.IsPalindromeTwo (number));
            }
        }

        private static void RomanToIntegerTest () {
            Console.WriteLine ("\nRoman To Integer question:");

            RomanToInteger romanToInteger = new RomanToInteger ();

            string[] testStrings = new string[] { "III", "IV", "IX", "LVIII", "MCMXCIV" };
            foreach (string str in testStrings) {
                Console.WriteLine ("{0} -> {1}", str, romanToInteger.RomanToInt (str));
            }
        }

        private static void IntegerToRomanTest () {
            Console.WriteLine ("\nInteger To Roman question:");

            IntegerToRoman integerToRoman = new IntegerToRoman ();

            int[] testNumbers = new int[] { 3, 4, 9, 58, 1994 };
            foreach (int number in testNumbers) {
                Console.WriteLine ("{0} -> {1}", number, integerToRoman.IntToRoman (number));
            }
        }

        private static void LongestCommonPrefixTest () {
            Console.WriteLine ("\nLongest Common Prefix question:");

            LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix ();

            IList<string[]> testStringArrays = new List<string[]> {
                new string[] { "flower", "flow", "flight" },
                new string[] { "dog", "racecar", "car" },
                new string[] { }
            };

            foreach (string[] stringArray in testStringArrays) {
                Console.WriteLine ("[{0}] -> {1}", string.Join (", ", stringArray), longestCommonPrefix.LongestCommonPrefixOne (stringArray));
            }

        }

        private static void ThreeSumTest () {
            Console.WriteLine ("\n3 Sum question:");

            ThreeSum threeSum = new ThreeSum ();

            IList<int[]> testNumberArrays = new List<int[]> {
                new int[] {-1, 0, 1, 2, -1, -4 }
            };

            foreach (int[] array in testNumberArrays) {
                Console.WriteLine ("[{0}] -> [", string.Join (", ", array));

                IList<IList<int>> solution = threeSum.ThreeSumOne (array);
                foreach (List<int> set in solution) {
                    Console.WriteLine ("[{0}],", string.Join (", ", set));
                }

                Console.WriteLine ("]");
            }
        }

        private static void ThreeSumClosestTest () {
            Console.WriteLine ("\n3 Sum Closest question:");

            ThreeSumClosest threeSumClosest = new ThreeSumClosest ();

            IList<Tuple<int[], int>> testNumberArrays = new List<Tuple<int[], int>> {
                Tuple.Create (new int[] {-1, 2, 1, -4 }, 1),
                Tuple.Create (new int[] { 1, 2, 4, 8, 16, 32, 64, 128 }, 82),
                Tuple.Create (new int[] { 1, 1, -1, -1, 3 }, -1),
                Tuple.Create (new int[] {-1, 2, 1, -4 }, 1)
            };

            foreach (Tuple<int[], int> pair in testNumberArrays) {
                Console.WriteLine ("[{0}] -> {1}", string.Join (", ", pair.Item1), threeSumClosest.ThreeSumClosestOne (pair.Item1, pair.Item2));
            }
        }

        private static void LetterCombinationsTest () {
            Console.WriteLine ("\n3 Letter Combinations question:");

            LetterCombinations letterCombinations = new LetterCombinations ();

            IList<string> testStrings = new List<string> {
                "23"
            };

            foreach (string testString in testStrings) {
                Console.WriteLine ("{0} -> [{1}]", testString, String.Join (", ", letterCombinations.LetterCombinationsOne (testString)));
            }
        }
    }
}