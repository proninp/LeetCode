using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1816. Truncate Sentence
     * A sentence is a list of words that are separated by a single space with no leading or trailing spaces.
     * Each of the words consists of only uppercase and lowercase English letters (no punctuation).
     * For example, "Hello World", "HELLO", and "hello world hello world" are all sentences.
     * You are given a sentence s​​​​​​ and an integer k​​​​​​.
     * You want to truncate s​​​​​​ such that it contains only the first k​​​​​​ words. Return s​​​​​​ after truncating it.
     */
    internal class _1816TruncateSentence
    {
        public string TruncateSentence(string s, int k)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && --k == 0)
                    return s.Substring(0, i);
            }
            return s;
        }
    }
}
