namespace LeetCode.Easy._0219._Contains_Duplicate_II.src;

public sealed class Solution
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.TryAdd(nums[i], i))
            {
                if (Math.Abs(map[nums[i]] - i) <= k)
                    return true;
                map[nums[i]] = i;
            }
        }
        return false;
    }
}