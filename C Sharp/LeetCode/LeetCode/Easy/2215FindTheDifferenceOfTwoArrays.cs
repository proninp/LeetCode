namespace LeetCode.Easy
{
    /*
     * 2215. Find the Difference of Two Arrays
     * 
     * Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:
     * answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
     * answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
     * Note that the integers in the lists may be returned in any order.
     */
    public class _2215FindTheDifferenceOfTwoArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var s1 = new HashSet<int>(nums1);
            var s2 = new HashSet<int>(nums2);
            s1.ExceptWith(nums2);
            s2.ExceptWith(nums1);
            return new List<IList<int>>() { nums1.Except(nums2).ToArray(), nums2.Except(nums1).ToArray() };
        }
    }
}
