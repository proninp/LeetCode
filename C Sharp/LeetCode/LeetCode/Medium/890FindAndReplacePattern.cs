using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 890. Find and Replace Pattern
     * Given a list of strings words and a string pattern, return a list of words[i] that match pattern.
     * You may return the answer in any order.
     * A word matches the pattern if there exists a permutation of letters p
     * so that after replacing every letter x in the pattern with p(x), we get the desired word.
     * Recall that a permutation of letters is a bijection from letters to letters:
     * every letter maps to another letter, and no two letters map to the same letter.
     */
    internal class _890FindAndReplacePattern
    {
        public static IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var list = new List<string>();
            int patternLen = pattern.Length;
            foreach (var word in words)
            {
                if (word.Length != patternLen)
                    continue;
                var mapWord = new Dictionary<char, char>();
                var mapPattern = new Dictionary<char, char>();
                bool isMatch = true;
                for (int i = 0; i < patternLen && isMatch; i++)
                {
                    if (!mapWord.ContainsKey(word[i]))
                        mapWord.Add(word[i], pattern[i]);
                    else
                        isMatch = mapWord[word[i]] == pattern[i];
                    if (isMatch)
                    {
                        if (!mapPattern.ContainsKey(pattern[i]))
                            mapPattern.Add(pattern[i], word[i]);
                        else
                            isMatch = mapPattern[pattern[i]] == word[i];
                    }
                }
                if (isMatch)
                    list.Add(word);
            }
            return list;
        }
    }
}
