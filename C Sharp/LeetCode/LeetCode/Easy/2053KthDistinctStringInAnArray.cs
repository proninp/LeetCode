using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2053. Kth Distinct String in an Array
     * A distinct string is a string that is present only once in an array.
     * Given an array of strings arr, and an integer k,
     * return the kth distinct string present in arr.
     * If there are fewer than k distinct strings, return an empty string "".
     * Note that the strings are considered in the order in which they appear in the array.
     */
    internal class _2053KthDistinctStringInAnArray
    {
        public string KthDistinct(string[] arr, int k)
        {
            var map = new Dictionary<string, int>(arr.Length);
            foreach (var item in arr)
                if (!map.ContainsKey(item))
                    map.Add(item, 1);
                else
                    map[item]++;
            foreach(var pair in map)
            {
                if (pair.Value == 1)
                {
                    k--;
                    if (k == 0)
                        return pair.Key;
                }
            }
            return "";
        }
    }
}
