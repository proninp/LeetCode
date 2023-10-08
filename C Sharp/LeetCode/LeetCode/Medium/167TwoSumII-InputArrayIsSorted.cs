namespace LeetCode.Medium
{
    /*
     * 167. Two Sum II - Input Array Is Sorted
     * 
     * Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order,
     * find two numbers such that they add up to a specific target number.
     * Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 < numbers.length.
     * Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.
     * The tests are generated such that there is exactly one solution. You may not use the same element twice.
     * Your solution must use only constant extra space.
     */

    public class _167TwoSumII_InputArrayIsSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int len = numbers.Length, sub;
            for (int l = 0, r = len - 1; l < r;)
            {
                sub = numbers[l] + numbers[r];
                if (sub > target) r--;
                else if (sub < target) l++;
                else return new int[] { l + 1, r + 1 };
            }
            return new int[] { -1, -1 };
        }
    }
}
