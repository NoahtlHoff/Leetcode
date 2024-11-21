using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Challenges_TopKFrequentElements
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int number in nums)
            {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }
            return frequency
                .OrderByDescending(pair => pair.Value)
                .Take(k)
                .Select(pair => pair.Key)
                .ToArray();
        }
    }
}
