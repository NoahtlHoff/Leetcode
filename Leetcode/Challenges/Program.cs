namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 3, 4, 4, 4 };
            int k = 2;
            Solution solution = new Solution();
            int[] result = solution.TopKFrequent(nums, k);
        }
    }
   
}
