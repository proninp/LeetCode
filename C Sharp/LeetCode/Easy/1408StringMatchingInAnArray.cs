using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1408. String Matching in an Array
     * Given an array of string words, return all strings in words that is a substring of another word. You can return the answer in any order.
     * A substring is a contiguous sequence of characters within a string
     */
    internal class _1408StringMatchingInAnArray
    {
        public IList<string> StringMatching(string[] words)
        {
            var list = new List<string>();
            int j;
            for (int i = 0; i < words.Length; i++)
            {
                bool isFound = false;
                j = 0;
                while (j < words.Length && !isFound)
                {
                    if (words[j].Contains(words[i]) && i != j)
                    {
                        list.Add(words[i]);
                        isFound = true;
                    }
                    j++;
                }
            }
            return list;
        }
    }
}
