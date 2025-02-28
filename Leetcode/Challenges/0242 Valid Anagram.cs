using System;
using System.Collections.Generic;

namespace LeetCode.Challenges.P0242  // 🔥 Fixed Namespace
{
    public class Solution : ILeetCodeProblem  // 🔥 Implementing the Interface
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            int[] charCount = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                charCount[s[i] - 'a']++;
                charCount[t[i] - 'a']--;
            }

            foreach (int count in charCount)
            {
                if (count != 0) return false;
            }

            return true;
        }

        // 🔥 Implementing Run() for Automatic Execution
        public void Run()
        {
            Console.WriteLine("Running Valid Anagram Test Cases:");

            string test1_s = "anagram", test1_t = "nagaram";
            string test2_s = "rat", test2_t = "car";
            string test3_s = "listen", test3_t = "silent";
            string test4_s = "hello", test4_t = "world";

            Console.WriteLine($"Input: \"{test1_s}\", \"{test1_t}\" -> Output: {IsAnagram(test1_s, test1_t)} (Expected: True)");
            Console.WriteLine($"Input: \"{test2_s}\", \"{test2_t}\" -> Output: {IsAnagram(test2_s, test2_t)} (Expected: False)");
            Console.WriteLine($"Input: \"{test3_s}\", \"{test3_t}\" -> Output: {IsAnagram(test3_s, test3_t)} (Expected: True)");
            Console.WriteLine($"Input: \"{test4_s}\", \"{test4_t}\" -> Output: {IsAnagram(test4_s, test4_t)} (Expected: False)");
        }
    }
}
