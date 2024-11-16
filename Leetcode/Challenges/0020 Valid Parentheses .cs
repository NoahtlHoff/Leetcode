using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Challenges_ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            HashSet<char> open = new HashSet<char> { '{', '[', '(' };
            Dictionary<char, char> close = new Dictionary<char, char> {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' }
            };
            Stack<char> sStack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char cur = s[i];
                if (open.Contains(cur))
                {
                    sStack.Push(cur);
                }
                else
                {
                    char match = close[cur];
                    if (sStack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (match != sStack.Peek())
                        {
                            return false;
                        }
                        else
                        {
                            sStack.Pop();
                        }
                    }
                }
            }
            if (sStack.Count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
