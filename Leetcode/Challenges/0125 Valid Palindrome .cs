using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.Challenges_ValidPalinDrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            string removedS = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
            char[] charArray = removedS.ToCharArray();
            Array.Reverse(charArray);
            string reverseS = new string(charArray);
            if (removedS == reverseS)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }
    }
}
