using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2399. Check Distances Between Same Letters
     * You are given a 0-indexed string s consisting of only lowercase English letters,
     * where each letter in s appears exactly twice. You are also given a 0-indexed integer array distance of length 26.
     * Each letter in the alphabet is numbered from 0 to 25 (i.e. 'a' -> 0, 'b' -> 1, 'c' -> 2, ... , 'z' -> 25).
     * In a well-spaced string, the number of letters between the two occurrences of the ith letter is distance[i].
     * If the ith letter does not appear in s, then distance[i] can be ignored.
     * Return true if s is a well-spaced string, otherwise return false.
     */
    internal class _2399CheckDistancesBetweenSameLetters
    {
        public bool CheckDistances(string s, int[] distance)
        {
            var track = new int[26];
            track[s[0] - 'a'] = -1;
            for (int i = 1; i < s.Length; i++)
            {
                int ind = s[i] - 'a';
                if (track[ind] == 0)
                    track[ind] = i;
                else
                {
                    var dist = i - (track[ind] != -1 ? track[ind] : 0) - 1;
                    if ((i - (track[ind] != -1 ? track[ind] : 0) - 1) != distance[ind])
                        return false;
                }
            }
            return true;
        }
    }
}
