namespace LeetCode.Medium._0128._Longest_Consecutive_Sequence.src;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var longest = 0;
        foreach (var e in set)
        {
            if (set.Contains(e - 1)) continue;
            var currentLength = 1;
            var num = e + 1;
            while (set.Contains(num))
            {
                currentLength++;
                num++;
            }
            longest = Math.Max(longest, currentLength);
        }
        return longest;
    }
}