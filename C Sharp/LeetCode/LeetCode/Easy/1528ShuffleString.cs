using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1528. Shuffle String
     * You are given a string s and an integer array indices of the same length.
     * The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
     * Return the shuffled string.
     */
    internal class _1528ShuffleString
    {
        public string RestoreString(string s, int[] indices)
        {
            int len = indices.Length;
            char[] ans = new char[len];
            for (int i = 0; i < len; i++)
                ans[indices[i]] = s[i];
            return string.Concat(ans);
        }
    }
}
