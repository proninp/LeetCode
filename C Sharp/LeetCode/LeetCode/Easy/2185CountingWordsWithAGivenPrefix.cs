using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2185. Counting Words With a Given Prefix
     * You are given an array of strings words and a string pref.
     * Return the number of strings in words that contain pref as a prefix.
     * A prefix of a string s is any leading contiguous substring of s.
     */
    internal class _2185CountingWordsWithAGivenPrefix
    {
        public int PrefixCount(string[] words, string pref)
        {
            int cnt = 0;
            int prefLen = pref.Length;
            foreach(string word in words)
            {
                if (word.Length >= prefLen)
                {
                    if (word.Substring(0, prefLen).Equals(pref))
                        cnt++;
                }
            }
            return cnt;
        }
    }
}
