using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 242. Valid Anagram
     * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
     * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
     * typically using all the original letters exactly once.
    */
    internal class _242ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] a = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                a[s[i] - 'a']++;
                a[t[i] - 'a']--;
            }
            return a.All(x => x == 0);
        }
    }
}
