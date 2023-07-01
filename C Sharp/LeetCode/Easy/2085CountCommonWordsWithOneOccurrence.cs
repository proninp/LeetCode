using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * Given two string arrays words1 and words2, return the number of strings
     * that appear exactly once in each of the two arrays.
     */
    internal class _2085CountCommonWordsWithOneOccurrence
    {
        public int CountWords(string[] words1, string[] words2)
        {
            var mapW1 = new Dictionary<string, int>(words1.Length);
            var mapW2 = new Dictionary<string, int>(words2.Length);
            foreach (var word in words1)
            {
                if (mapW1.ContainsKey(word))
                    mapW1[word]++;
                else
                    mapW1.Add(word, 1);
            }
            foreach (var word in words2)
            {
                if (mapW2.ContainsKey(word))
                    mapW2[word]++;
                else
                    mapW2.Add(word, 1);
            }
            return mapW1.Where(kvp => (kvp.Value == 1) && mapW2.ContainsKey(kvp.Key) && (mapW2[kvp.Key] == 1)).Count();
        }
    }
}
