using System.Collections.Generic;

namespace LeetCode.Easy
{
    /*
     * 1512. Number of Good Pairs
     * 
     * Given an array of integers nums, return the number of good pairs.
     * A pair (i, j) is called good if nums[i] == nums[j] and i < j.
     * 
     * Constraints:
     * 1 <= nums.length <= 100
     * 1 <= nums[i] <= 100
     */
    internal class _1512NumberOfGoodPairs
    {
        public static int NumIdenticalPairs2(int[] nums)
        {
            var counts = new int[102];
            foreach (var e in nums)
                counts[e]++;
            int ans = 0;
            foreach (var e in counts)
                ans += (e * (e - 1)) / 2;
            return ans;
        }

        public static int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int ans = 0;
            foreach (var i in nums)
            {
                int e = map.ContainsKey(i) ? map[i] : 0;
                ans += e;
                map[i] = e + 1;
            }
            return ans;
        }
    }
}
