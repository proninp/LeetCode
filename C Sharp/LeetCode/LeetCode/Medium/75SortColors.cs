using System.Collections.Generic;

namespace LeetCode.Medium
{
    /*
     * 75. Sort Colors
     * Given an array nums with n objects colored red, white, or blue,
     * sort them in-place so that objects of the same color are adjacent,
     * with the colors in the order red, white, and blue.
     * We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
     * You must solve this problem without using the library's sort function.
     */
    internal class _75SortColors
    {
        public void SortColors(int[] nums)
        {
            var map = new int[3];
            foreach (var n in nums)
                map[n]++;
            int i = 0;
            for (int j = 0; j < map.Length; j++)
                while (map[j]-- > 0)
                    nums[i++] = j;
        }
    }
}
