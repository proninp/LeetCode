namespace LeetCode.Easy._0169._Majority_Element.src;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var mid = nums.Length / 2;
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map.Add(nums[i], 1);

            if (map[nums[i]] > mid)
                return nums[i];
        }
        return nums[0];
    }
}

