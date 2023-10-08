using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 268. Missing Number
     * Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
     */
    internal class _268MissingNumber
    {
        public static int MissingNumber(int[] nums)
        {
            int len = nums.Length;
            return len * (len + 1) / 2 - nums.Sum();
        }
    }
}
