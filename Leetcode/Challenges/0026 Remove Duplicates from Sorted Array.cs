using System;

namespace LeetCode.Challenges.P0026  // 🔥 Fixed Namespace
{
    public class Solution : ILeetCodeProblem  // 🔥 Implementing the Interface
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int k = 1;  // The first element is always unique

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[k - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }

        // 🔥 Implementing Run() for Automatic Execution
        public void Run()
        {
            Console.WriteLine("Running Remove Duplicates Test Cases:");

            int[] test1 = { 1, 1, 2 };
            int[] test2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            Console.WriteLine($"Input: [1, 1, 2] -> Output: {RemoveDuplicates(test1)} (Expected: 2)");
            Console.WriteLine($"Input: [0, 0, 1, 1, 1, 2, 2, 3, 3, 4] -> Output: {RemoveDuplicates(test2)} (Expected: 5)");
        }
    }
}
