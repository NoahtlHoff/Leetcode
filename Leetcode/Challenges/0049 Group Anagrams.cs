using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Challenges.P0049  // 🔥 Fixed Namespace (Consistent Naming)
{
    public class Solution : ILeetCodeProblem  // 🔥 Implementing the Interface
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> grouped = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                char[] sortedChars = word.ToCharArray();
                Array.Sort(sortedChars);
                string key = new string(sortedChars);

                if (!grouped.ContainsKey(key))
                {
                    grouped[key] = new List<string>();
                }

                grouped[key].Add(word);
            }

            return grouped.Values.ToList();
        }

        // 🔥 Implementing Run() for Automatic Execution
        public void Run()
        {
            Console.WriteLine("Running Group Anagrams Test Cases:");

            string[] test1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
            string[] test2 = { "" };
            string[] test3 = { "a" };

            Console.WriteLine($"Input: [\"eat\", \"tea\", \"tan\", \"ate\", \"nat\", \"bat\"]");
            PrintResult(GroupAnagrams(test1));

            Console.WriteLine($"Input: [\"\"]");
            PrintResult(GroupAnagrams(test2));

            Console.WriteLine($"Input: [\"a\"]");
            PrintResult(GroupAnagrams(test3));
        }

        private void PrintResult(IList<IList<string>> result)
        {
            Console.Write("[");
            foreach (var group in result)
            {
                Console.Write("[\"" + string.Join("\", \"", group) + "\"], ");
            }
            Console.WriteLine("]");
        }
    }
}
