namespace LeetCode.Easy._0217._Contains_Duplicate.src;

public sealed class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> map = new();
        foreach (int x in nums)
        {
            if (!map.TryAdd(x, x))
                return true;
        }
        return false;
    }
}