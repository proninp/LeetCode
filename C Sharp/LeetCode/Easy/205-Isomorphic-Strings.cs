using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 205. Isomorphic Strings
     * Given two strings s and t, determine if they are isomorphic.
     * Two strings s and t are isomorphic if the characters in s can be replaced to get t.
     * All occurrences of a character must be replaced with another character while preserving the order of characters.
     * No two characters may map to the same character, but a character may map to itself.
     */
    internal class _205_Isomorphic_Strings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> mapST = new Dictionary<char, char>();
            Dictionary<char, char> mapTS = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if ((mapST.ContainsKey(s[i]) && mapST[s[i]] != t[i]) || (mapTS.ContainsKey(t[i]) && mapTS[t[i]] != s[i]))
                    return false;
                else
                {
                    mapST[s[i]] = t[i];
                    mapTS[t[i]] = s[i];
                }
            }
            return true;
        }
    }
}
