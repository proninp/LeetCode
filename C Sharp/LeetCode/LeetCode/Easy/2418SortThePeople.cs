using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2418. Sort the People
     * You are given an array of strings names, and an array heights that consists of distinct positive integers. Both arrays are of length n.
     * For each index i, names[i] and heights[i] denote the name and height of the ith person.
     * Return names sorted in descending order by the people's heights.
     */
    internal class _2418SortThePeople
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            int n = heights.Length;
            var map = new Dictionary<int, string>(n);
            for (int i = 0; i < n; i++)
                map.Add(heights[i], names[i]);
            Array.Sort(heights);
            var ans = new string[n];
            foreach(var h in heights)
                ans[--n] = map[h];
            return ans;
        }
    }
}
