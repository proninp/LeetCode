using System;

namespace LeetCode.Easy
{
    public class _1984MinimumDifferenceBetweenHighestAndLowestOfKScores
    {
        /*
         * 1984. Minimum Difference Between Highest and Lowest of K Scores
         * You are given a 0-indexed integer array nums, where nums[i] represents the score of the ith student.
         * You are also given an integer k.
         * Pick the scores of any k students from the array so that the difference
         * between the highest and the lowest of the k scores is minimized.
         * Return the minimum possible difference.
         */
        public int MinimumDifference(int[] nums, int k)
        {
            Array.Sort(nums);
            int min = int.MaxValue;
            int l = 0, r = k - 1;
            while (r < nums.Length)
                min = Math.Min(min, nums[r++] - nums[l++]);
            return min;
        }
    }
}
