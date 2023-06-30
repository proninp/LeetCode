using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 893. Groups of Special-Equivalent Strings
     * You are given an array of strings of the same length words.
     * In one move, you can swap any two even indexed characters or any two odd indexed characters of a string words[i].
     * Two strings words[i] and words[j] are special-equivalent if after any number of moves, words[i] == words[j].
     * For example, words[i] = "zzxy" and words[j] = "xyzz" are special-equivalent because we may make the moves "zzxy" -> "xzzy" -> "xyzz".
     * A group of special-equivalent strings from words is a non-empty subset of words such that:
     * Every pair of strings in the group are special equivalent, and
     * The group is the largest size possible (i.e., there is not a string words[i]
     * not in the group such that words[i] is special-equivalent to every string in the group).
     * Return the number of groups of special-equivalent strings from words.
     */
    internal class _893GroupsOfSpecialEquivalentStrings
    {
        public int NumSpecialEquivGroups(string[] words)
        {
            var set = new HashSet<string>();
            foreach(var word in words)
            {
                var odd = new int[26];
                var even = new int[26];
                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                        even[word[i] - 'a']++;
                    else
                        odd[word[i] - 'a']++;
                }
                set.Add(string.Concat(odd) + string.Concat(even));
            }
            return set.Count;
        }
    }
}
