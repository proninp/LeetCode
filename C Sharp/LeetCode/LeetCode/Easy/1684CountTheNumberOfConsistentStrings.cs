using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1684. Count the Number of Consistent Strings
     * You are given a string allowed consisting of distinct characters and an array of strings words.
     * A string is consistent if all characters in the string appear in the string allowed.
     * Return the number of consistent strings in the array words.
     */
    internal class _1684CountTheNumberOfConsistentStrings
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            bool[] a = new bool[26];
            for (int i = 0; i < allowed.Length; i++)
                a[allowed[i] - 'a'] = true;
            int consistents = words.Length;
            foreach(var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!a[word[i] - 'a'])
                    {
                        consistents--;
                        break;
                    }
                }
            }
            return consistents;
        }
    }
}
