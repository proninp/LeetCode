using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2451. Odd String Difference
     * You are given an array of equal-length strings words. Assume that the length of each string is n.
     * Each string words[i] can be converted into a difference integer array difference[i] of length n - 1 where
     * difference[i][j] = words[i][j+1] - words[i][j] where 0 <= j <= n - 2.
     * Note that the difference between two letters is the difference between
     * their positions in the alphabet i.e. the position of 'a' is 0, 'b' is 1, and 'z' is 25.
     * For example, for the string "acb", the difference integer array is [2 - 0, 1 - 2] = [2, -1].
     * All the strings in words have the same difference integer array, except one. You should find that string.
     * Return the string in words that has different difference integer array.
     */
    internal class _2451OddStringDifference
    {
        public string OddString(string[] words)
        {
            if (IsEqual(words[0], words[1]))
            {
                for (int i = 2; i < words.Length; i++)
                {
                    if (!IsEqual(words[0], words[i]))
                        return words[i];
                }
            }
            else
            {
                if (IsEqual(words[2], words[0]))
                    return words[1];
                else
                    return words[0];
            }
            return "";
        }
        public bool IsEqual(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            for (int i = 1; i < s1.Length; i++)
                if ((s1[i] - s1[i - 1]) != (s2[i] - s2[i - 1]))
                    return false;
            return true;
        }
    }
}
