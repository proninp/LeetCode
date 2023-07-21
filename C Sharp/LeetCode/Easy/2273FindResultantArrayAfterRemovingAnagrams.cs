using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2273. Find Resultant Array After Removing Anagrams
     * You are given a 0-indexed string array words, where words[i] consists of lowercase English letters.
     * In one operation, select any index i such that 0 < i < words.length and words[i - 1] and words[i] are anagrams,
     * and delete words[i] from words. Keep performing this operation as long as you can select an index that satisfies the conditions.
     * Return words after performing all operations.
     * It can be shown that selecting the indices for each operation in any arbitrary order will lead to the same result.
     * An Anagram is a word or phrase formed by rearranging the letters of
     * a different word or phrase using all the original letters exactly once.
     * For example, "dacb" is an anagram of "abdc".
     */
    internal class _2273FindResultantArrayAfterRemovingAnagrams
    {
        public IList<string> RemoveAnagrams(string[] words)
        {
            var list = new List<string>() { words[0] };
            var m1 = GetMap(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                var m2 = GetMap(words[i]);
                if (!IsMapEquals(m1, m2))
                {
                    list.Add(words[i]);
                    m1 = m2;
                }
            }
            return list;
        }
        private int[] GetMap(string s)
        {
            int[] map = new int[26];
            foreach (char c in s)
                map[c - 'a']++;
            return map;
        }
        private bool IsMapEquals(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
                if (arr1[i] != arr2[i])
                    return false;
            return true;
        }
    }
}
