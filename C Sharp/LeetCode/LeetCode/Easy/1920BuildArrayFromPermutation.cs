using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1920. Build Array from Permutation
     * Given a zero-based permutation nums (0-indexed),
     * build an array ans of the same length where ans[i] = nums[nums[i]] for each 0 <= i < nums.length and return it.
     * A zero-based permutation nums is an array of distinct integers from 0 to nums.length - 1 (inclusive).
     */
    internal class _1920BuildArrayFromPermutation
    {
        public static int[] BuildArray(int[] nums)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                list.Add(nums[nums[i]]);
            return list.ToArray();
        }
    }
}
