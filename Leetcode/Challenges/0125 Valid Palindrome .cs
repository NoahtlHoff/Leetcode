using System;
using System.Text.RegularExpressions;

namespace LeetCode.Challenges.P0125  // 🔥 Fixed Namespace
{
    public class Solution : ILeetCodeProblem  // 🔥 Implementing the Interface
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            string cleanedString = Regex.Replace(s, @"[^a-zA-Z0-9]", ""); // 🔥 Remove non-alphanumeric chars

            int left = 0, right = cleanedString.Length - 1;
            while (left < right)
            {
                if (cleanedString[left] != cleanedString[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }

        // 🔥 Implementing Run() for Automatic Execution
        public void Run()
        {
            Console.WriteLine("Running Valid Palindrome Test Cases:");

            string test1 = "A man, a plan, a canal: Panama";
            string test2 = "race a car";
            string test3 = " ";
            string test4 = "No 'x' in Nixon";

            Console.WriteLine($"Input: \"{test1}\" -> Output: {IsPalindrome(test1)} (Expected: True)");
            Console.WriteLine($"Input: \"{test2}\" -> Output: {IsPalindrome(test2)} (Expected: False)");
            Console.WriteLine($"Input: \"{test3}\" -> Output: {IsPalindrome(test3)} (Expected: True)");
            Console.WriteLine($"Input: \"{test4}\" -> Output: {IsPalindrome(test4)} (Expected: True)");
        }
    }
}
