namespace LeetCode.Easy._0228._Summary_Ranges.src;

public sealed class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> list = new();
        if (nums.Length == 0)
            return list;
        int first = nums[0], last = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != last + 1)
            {
                list.Add(first != last ? first + "->" + last : first.ToString());
                first = nums[i];
            }
            last = nums[i];
        }
        list.Add(first != last ? first + "->" + last : first.ToString());
        return list;
    }
}