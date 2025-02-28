using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Challenges.P0347  // 🔥 Fixed Namespace
{
    public class Solution : ILeetCodeProblem  // 🔥 Implementing the Interface
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (frequency.ContainsKey(num))
                    frequency[num]++;
                else
                    frequency[num] = 1;
            }

            // 🔥 Use a Min-Heap (PriorityQueue in .NET 6+)
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

            foreach (var pair in frequency)
            {
                minHeap.Enqueue(pair.Key, pair.Value);
                if (minHeap.Count > k)  // Keep only top K elements
                    minHeap.Dequeue();
            }

            int[] result = new int[k];
            for (int i = k - 1; i >= 0; i--)
                result[i] = minHeap.Dequeue();

            return result;
        }

        // 🔥 Implementing Run() for Automatic Execution
        public void Run()
        {
            Console.WriteLine("Running Top K Frequent Elements Test Cases:");

            int[] test1 = { 1, 1, 1, 2, 2, 3 };
            int k1 = 2;

            int[] test2 = { 1 };
            int k2 = 1;

            int[] test3 = { 4, 1, -1, 2, -1, 2, 3 };
            int k3 = 2;

            Console.WriteLine($"Input: [1,1,1,2,2,3], k = 2 -> Output: [{string.Join(", ", TopKFrequent(test1, k1))}] (Expected: [1, 2])");
            Console.WriteLine($"Input: [1], k = 1 -> Output: [{string.Join(", ", TopKFrequent(test2, k2))}] (Expected: [1])");
            Console.WriteLine($"Input: [4,1,-1,2,-1,2,3], k = 2 -> Output: [{string.Join(", ", TopKFrequent(test3, k3))}] (Expected: [-1, 2])");
        }
    }
}
