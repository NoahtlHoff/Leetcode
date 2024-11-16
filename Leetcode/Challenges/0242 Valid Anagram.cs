using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Challenges_ValidAnagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            Char[] sChar = s.ToCharArray();
            Char[] tChar = t.ToCharArray();
            Array.Sort(sChar);
            Array.Sort(tChar);
            return sChar.SequenceEqual(tChar);
        }
    }
}
