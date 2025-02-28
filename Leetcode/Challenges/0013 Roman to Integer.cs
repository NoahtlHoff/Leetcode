using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Challenges.P0013;

public class Solution : ILeetCodeProblem
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
    public void Run()
    {
        Console.WriteLine("Running RomanToInt Test Cases:");

        string test1 = "III";
        string test2 = "LVIII";
        string test3 = "MCMXCIV";

        Console.WriteLine($"Input: {test1} -> Output: {RomanToInt(test1)} (Expected: 3)");
        Console.WriteLine($"Input: {test2} -> Output: {RomanToInt(test2)} (Expected: 58)");
        Console.WriteLine($"Input: {test3} -> Output: {RomanToInt(test3)} (Expected: 1994)");
    }
}
