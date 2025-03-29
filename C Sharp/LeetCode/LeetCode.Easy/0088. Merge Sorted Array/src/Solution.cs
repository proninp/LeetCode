namespace LeetCode.Easy._0088._Merge_Sorted_Array.src;

public sealed class Solution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var last = nums1.Length - 1;
        int p1 = m - 1, p2 = n - 1;
        while (n > 0)
        {
            if (m > 0 && nums1[p1] > nums2[p2])
            {
                nums1[last] = nums1[p1--];
            }
            else
            {
                nums1[last] = nums2[p2--];
            }
            last--;
        }
    }
}

