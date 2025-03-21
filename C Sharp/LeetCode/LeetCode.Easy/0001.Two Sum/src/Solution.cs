namespace LeetCode.Easy._0001.Two_Sum.src;

public sealed class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var seek = target - nums[i];
            if (map.ContainsKey(seek))
                return [map[seek], i];
            map[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}