using System.Collections.Generic;

namespace LeetCode.Easy
{
    /*
     * 2824. Count Pairs Whose Sum is Less than Target
     * Given a 0-indexed integer array nums of length n and an integer target,
     * return the number of pairs (i, j) where 0 <= i < j < n and nums[i] + nums[j] < target.
     */
    internal class _2824CountPairsWhoseSumIsLessThanTarget
    {
        public int CountPairs(IList<int> nums, int target)
        {
            int len = nums.Count;
            int res = 0;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (nums[i] + nums[j] < target)
                        res++;
                }
            }
            return res;
        }
    }
}
