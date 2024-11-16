using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Challenges_GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Dictionary<string, List<string>> grouped = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] compareWord = strs[i].ToCharArray();
                Array.Sort(compareWord);
                string key = new string(compareWord);

                if (grouped.ContainsKey(key))
                {
                    grouped[key].Add(strs[i]);
                }
                else
                {
                    grouped[key] = new List<string> { strs[i] };
                }
            }
            foreach (var group in grouped.Values)
            {
                result.Add(group);
            }

            return result;
        }
    }
}
