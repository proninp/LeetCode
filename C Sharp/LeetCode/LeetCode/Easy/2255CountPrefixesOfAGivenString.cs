using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2255. Count Prefixes of a Given String
     * You are given a string array words and a string s, where words[i] and s comprise only of lowercase English letters.
     * Return the number of strings in words that are a prefix of s.
     * A prefix of a string is a substring that occurs at the beginning of the string. A substring is a contiguous sequence of characters within a string.
     */
    internal class _2255CountPrefixesOfAGivenString
    {
        public int CountPrefixes(string[] words, string s)
        {
            int cnt = 0;
            int sLen = s.Length;
            foreach(var word in words)
            {
                if (sLen >= word.Length)
                    if (s.StartsWith(word))
                        cnt++;
            }
            return cnt;
        }
    }
}
