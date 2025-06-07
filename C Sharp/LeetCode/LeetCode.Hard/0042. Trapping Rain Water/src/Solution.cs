namespace LeetCode.Hard._0042._Trapping_Rain_Water.src;

public class Solution
{
    public int Trap(int[] height)
    {
        var totalVolume = 0;
        
        int left = 0, right = height.Length - 1;
        var leftMax = height[0];
        var rightMax = height[right];

        while (left < right)
        {
            if (height[left] < height[right])
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                totalVolume += leftMax - height[left];
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                totalVolume += rightMax - height[right];
            }
        }
        
        return totalVolume;
    }
    
    public int Trap2(int[] height)
    {
        var length = height.Length;
        var prefixes = new int[length];
        var suffixes = new int[length];

        int maxPrefix = 0, maxSuffix = 0;
        for (int i = 0, j = length - 1; i < length && j >= 0; i++, j--)
        {
            prefixes[i] = maxPrefix;
            suffixes[j] = maxSuffix;
            maxPrefix = Math.Max(maxPrefix, height[i]);
            maxSuffix = Math.Max(maxSuffix, height[j]);
        }

        var totalVolume = 0;

        for (var i = 0; i < length; i++)
        {
            var waterVolume = Math.Min(prefixes[i], suffixes[i]) - height[i];
            if (waterVolume > 0)
                totalVolume += waterVolume;
        }
        
        return totalVolume;
    }
}