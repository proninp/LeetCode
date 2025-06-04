namespace LeetCode.Medium._0003._Longest_Substring_Without_Repeating_Characters.src;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var maxLength = 0;
        var left = 0;
        var right = 0;
        var set = new HashSet<char>(s.Length);
        while (right < s.Length)
        {
            if (!set.Add(s[right]))
            {
                maxLength = Math.Max(maxLength, right - left);
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[right]);
            }
            right++;
        }
        return Math.Max(maxLength, right - left);
    }
}