using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2586. Count the Number of Vowel Strings in Range
     * You are given a 0-indexed array of string words and two integers left and right.
     * A string is called a vowel string if it starts with a vowel character and ends with a vowel
     * character where vowel characters are 'a', 'e', 'i', 'o', and 'u'.
     * Return the number of vowel strings words[i] where i belongs to the inclusive range [left, right].
     */
    internal class _2586CountTheNumberOfVowelStringsInRange
    {
        public int VowelStrings(string[] words, int left, int right)
        {
            int ans = 0;
            HashSet<char> set = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            for (int i = left; i <= right; i++)
            {
                char f = words[i][0];
                char l = words[i][words[i].Length - 1];
                if (set.Contains(f) && (f == l || set.Contains(l)))
                    ans++;
            }
            return ans;
        }
    }
}
