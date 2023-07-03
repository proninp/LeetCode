using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2506. Count Pairs Of Similar Strings
     * You are given a 0-indexed string array words.
     * Two strings are similar if they consist of the same characters.
     * For example, "abca" and "cba" are similar since both consist of characters 'a', 'b', and 'c'.
     * However, "abacba" and "bcfd" are not similar since they do not consist of the same characters.
     * Return the number of pairs (i, j) such that 0 <= i < j <= word.length - 1 and the two strings words[i] and words[j] are similar.
     */
    internal class _2506CountPairsOfSimilarStrings
    {
        public int SimilarPairs(string[] words)
        {
            int pairs = 0;
            var map = new Dictionary<string, int>();
            foreach(var word in words)
            {
                var arr = new bool[26];
                foreach (var c in word)
                    arr[c - 'a'] = true;
                var k = string.Concat(arr);
                if (!map.ContainsKey(k))
                    map.Add(k, 1);
                else
                {
                    pairs += map[k];
                    map[k]++;
                }
            }
            return pairs;
        }
    }
}
