using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2744. Find Maximum Number of String Pairs
     * You are given a 0-indexed array words consisting of distinct strings.
     * The string words[i] can be paired with the string words[j] if:
     * The string words[i] is equal to the reversed string of words[j].
     * 0 <= i < j < words.length.
     * Return the maximum number of pairs that can be formed from the array words.
     * Note that each string can belong in at most one pair.
     */
    internal class _2744FindMaximumNumberOfStringPairs
    {
        public int MaximumNumberOfStringPairs(string[] words)
        {
            var set = new HashSet<string>(words.Length);
            var ans = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (set.Contains(words[i]))
                    ans++;
                else
                {
                    var chars = words[i].ToCharArray();
                    Array.Reverse(chars);
                    var newWord = new string(chars);
                    set.Add(newWord);
                }
            }
            return ans;
        }
    }
}
