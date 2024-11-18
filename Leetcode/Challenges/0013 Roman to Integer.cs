using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Challenges_RomantoInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<Char, int> romanNumbers = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int intNumber = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int currentValue = romanNumbers[s[i]];
                if (i < s.Length - 1 && currentValue < romanNumbers[s[i+1]])
                {
                    intNumber -= currentValue;
                }
                else
                {
                    intNumber += currentValue;
                }
            }
   
            return intNumber; 
        }
    }
}
