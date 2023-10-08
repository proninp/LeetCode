using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 290. Word Pattern
     * Given a pattern and a string s, find if s follows the same pattern.
     * Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
     */
    internal class _290WordPattern
    {
        public bool WordPattern(string pattern, string s)
        {
            int len = pattern.Length;
            var mapChrToWord = new Dictionary<char, string>();
            var mapWordToChr = new Dictionary<string, char>();
            string[] words = s.Split(' ');
            if (words.Length != len) return false;
            for (int i = 0; i < len; i++)
            {
                if (!mapChrToWord.ContainsKey(pattern[i]))
                    mapChrToWord.Add(pattern[i], words[i]);
                else
                    if (mapChrToWord[pattern[i]] != words[i]) return false;
                if (!mapWordToChr.ContainsKey(words[i]))
                    mapWordToChr.Add(words[i], pattern[i]);
                else
                    if (mapWordToChr[words[i]] != pattern[i]) return false;
            }
            return true;
        }
    }
}
