using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1512. Number of Good Pairs
     * Given an array of integers nums, return the number of good pairs.
     * A pair (i, j) is called good if nums[i] == nums[j] and i < j.
     */
    internal class _1512NumberOfGoodPairs
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int ans = 0;
            foreach(var i in nums)
            {
                int e = map.ContainsKey(i) ? map[i] : 0;
                ans += e;
                map[i] = e + 1;
            }   
            return ans;
        }
    }
}
