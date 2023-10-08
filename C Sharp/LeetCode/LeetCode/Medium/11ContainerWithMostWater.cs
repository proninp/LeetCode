using System;

namespace LeetCode.Medium
{
    /*
     * 11. Container With Most Water
     * You are given an integer array height of length n.
     * There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
     * Find two lines that together with the x-axis form a container, such that the container contains the most water.
     * Return the maximum amount of water a container can store.
     * Notice that you may not slant the container.
     */
    public class _11ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxS = 0, l = 0, r = height.Length - 1;
            while (l < r)
            {
                maxS = Math.Max(Math.Min(height[l], height[r]) * (r - l), maxS);
                if (height[r] <= height[l]) r--;
                else l++;
            }
            return maxS;
        }
    }
}
