namespace LeetCode.Easy._0349._Intersection_of_Two_Arrays.src;

public sealed class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var set = new HashSet<int>();
        var freq = new int[1001];

        for (int i = 0; i < nums1.Length; i++)
            freq[nums1[i]]++;

        for (int i = 0;i < nums2.Length; i++)
            if (freq[nums2[i]] != 0)
                set.Add(nums2[i]);
        return set.ToArray();
    }
}