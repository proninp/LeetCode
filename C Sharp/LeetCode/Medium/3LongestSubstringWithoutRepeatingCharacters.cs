using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 3. Longest Substring Without Repeating Characters
     * Given a string s, find the length of the longest substring without repeating characters.
     */
    internal class _3LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();
            var maxSubst = 0;
            int l = 0;
            for (int r = 0; r < s.Length; r++)
            {
                while(set.Contains(s[r]))
                {
                    set.Remove(s[l]);
                    l++;
                }
                set.Add(s[r]);
                maxSubst = Math.Max(maxSubst, r - l + 1);
            }
            return maxSubst;
        }
    }
}
