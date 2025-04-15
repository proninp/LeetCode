namespace LeetCode.Easy._0350._Intersection_of_Two_Arrays_II.src;

public sealed class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var result = new List<int>();
        var freq = new int[1001];
        for (int i = 0; i < nums1.Length; i++)
            freq[nums1[i]]++;

        for (int i = 0; i < nums2.Length; i++)
        {
            if (freq[nums2[i]] > 0)
            {
                result.Add(nums2[i]);
                freq[nums2[i]]--;
            }
        }
        return result.ToArray();
    }
}