using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1662. Check If Two String Arrays are Equivalent
     * Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
     * A string is represented by an array if the array elements concatenated in order forms the string.
     */
    internal class _1662CheckIfTwoStringArraysAreEquivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();
            for (int i = 0; i < word1.Length; i++)
                sb1.Append(word1[i]);
            for (int i = 0; i < word2.Length; i++)
                sb2.Append(word2[i]);
            if (sb1.Length != sb2.Length)
                return false;
            return sb1.Equals(sb2);
        }
    }
}
