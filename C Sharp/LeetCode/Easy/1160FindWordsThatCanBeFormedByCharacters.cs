using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1160. Find Words That Can Be Formed by Characters
     * You are given an array of strings words and a string chars.
     * A string is good if it can be formed by characters from chars (each character can only be used once).
     * Return the sum of lengths of all good strings in words.
     */
    internal class _1160FindWordsThatCanBeFormedByCharacters
    {
        public int CountCharacters(string[] words, string chars)
        {
            int output = 0;
            var chFreq = new int[26];
            foreach(var c in chars)
                chFreq[c - 'a']++;
            foreach(var word in words)
            {
                bool isGood = true;
                var currFreq = new int[26];
                foreach(var c in word)
                    currFreq[c - 'a']++;
                for (int i = 0; (i < currFreq.Length) && isGood; i++)
                    isGood = currFreq[i] <= chFreq[i];
                if (isGood)
                    output += word.Length;
            }
            return output;
        }
    }
}
