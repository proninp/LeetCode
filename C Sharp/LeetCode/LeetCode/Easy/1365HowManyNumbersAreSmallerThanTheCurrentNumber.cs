using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /*
     * 1365. How Many Numbers Are Smaller Than the Current Number
     * Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it.
     * That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
     * Return the answer in an array.
     */
    internal class _1365HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var len = nums.Length;
            var outut = new int[len];
            var map = new Dictionary<int, int>(len);
            var list = nums.ToList();
            list.Sort();
            for (int i = 0; i < len; i++)
                if (!map.ContainsKey(list[i]))
                    map.Add(list[i], i);
            for (int i = 0; i < len; i++)
                outut[i] = map[nums[i]];
            return outut;
        }
    }
}
