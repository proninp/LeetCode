using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    internal class _49_group_anagrams
    {
        /*
         * 49. Group Anagrams
         * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
         * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
         * typically using all the original letters exactly once.
         */
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> ans = new List<IList<string>>();
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();
            foreach (string str in strs)
            {
                char[] chars = new char[26];
                foreach (var e in str)
                    chars[e - 'a']++;
                string key = new string(chars);
                if (!map.ContainsKey(key))
                    map.Add(key, new List<string>());
                map[key].Add(str);
            }
            return map.Values.ToList();
        }
    }
}
