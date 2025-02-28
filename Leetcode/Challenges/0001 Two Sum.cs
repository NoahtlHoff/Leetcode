using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeetCode.Challenges.P0001;
public class Solution : ILeetCodeProblem
{
    public int[] TwoSum(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j }; ;
                }
            }
        }
        return null;
    }
    public void Run()
    {
        int[] result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine($"[{string.Join(", ", result)}]"); // Expected Output: [0, 1]
    }
}