using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 392. Is Subsequence
     * Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
     * A subsequence of a string is a new string that is formed from the original string by deleting some (can be none)
     * of the characters without disturbing the relative positions of the remaining characters.
     * (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
     */
    internal class _392IsSubsequence
    {
        public static bool IsSubsequence(string s, string t)
        {
            int sInd = 0;
            int tInd = 0;
            while(sInd < s.Length && tInd < t.Length)
            {
                if (t[tInd] == s[sInd])
                    sInd++;
                tInd++;
            }
            return sInd == s.Length;
        }
    }
}
