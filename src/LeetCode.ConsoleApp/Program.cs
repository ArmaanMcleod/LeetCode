using System;
using LeetCode.ClassLib;

namespace LeetCode.ConsoleApp {
    class Program {
        public static void Main (string[] args) {
            Console.WriteLine ("Two Sum question");

            int[] testArray = { 3, 4, 2 };

            TwoSum twoSum = new TwoSum ();

            int[] result = twoSum.FindTwoSum (testArray, 6);
            Console.WriteLine ("[{0}, {1}]", result[0], result[1]);

        }
    }
}