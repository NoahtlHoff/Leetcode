using System;
using System.Collections.Generic;

namespace LeetCode.Challenges.P0020  // 🔥 Fixed Namespace (Consistent with other problems)
{
    public class Solution : ILeetCodeProblem  // 🔥 Implementing the Interface
    {
        public bool IsValid(string s)
        {
            HashSet<char> open = new HashSet<char> { '{', '[', '(' };
            Dictionary<char, char> close = new Dictionary<char, char>
            {
                { '}', '{' },
                { ']', '[' },
                { ')', '(' }
            };

            Stack<char> sStack = new Stack<char>();

            foreach (char cur in s)
            {
                if (open.Contains(cur))
                {
                    sStack.Push(cur);
                }
                else
                {
                    if (sStack.Count == 0 || sStack.Peek() != close[cur])
                    {
                        return false;
                    }
                    sStack.Pop();
                }
            }

            return sStack.Count == 0;
        }

        // 🔥 Implementing Run() for Automatic Execution
        public void Run()
        {
            Console.WriteLine("Running Valid Parentheses Test Cases:");

            string test1 = "()";
            string test2 = "()[]{}";
            string test3 = "(]";
            string test4 = "([)]";
            string test5 = "{[]}";

            Console.WriteLine($"Input: \"{test1}\" -> Output: {IsValid(test1)} (Expected: True)");
            Console.WriteLine($"Input: \"{test2}\" -> Output: {IsValid(test2)} (Expected: True)");
            Console.WriteLine($"Input: \"{test3}\" -> Output: {IsValid(test3)} (Expected: False)");
            Console.WriteLine($"Input: \"{test4}\" -> Output: {IsValid(test4)} (Expected: False)");
            Console.WriteLine($"Input: \"{test5}\" -> Output: {IsValid(test5)} (Expected: True)");
        }
    }
}
