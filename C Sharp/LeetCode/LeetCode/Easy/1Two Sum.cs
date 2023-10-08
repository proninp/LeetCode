using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1. Two Sum
     * Given an array of integers nums and an integer target,
     * return indices of the two numbers such that they add up to target.
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.
     * You can return the answer in any order.
     */
    internal class _1Two_Sum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int seek = target - nums[i];
                if (pairs.TryGetValue(seek, out int outIndex))
                    return new int[] { i, outIndex };
                else
                    pairs[nums[i]] = i;
            }
            return new int[] { -1, -1 };
        }
    }
}
