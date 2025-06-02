namespace LeetCode.Medium._0167._Two_Sum_II___Input_Array_Is_Sorted.src;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target) {        
        var i = 0;
        var j = numbers.Length - 1;
        while (i < j)
        {
            var sum = numbers[i] + numbers[j];
            if (sum > target)
            {
                j--;
            }
            else if (sum < target)
            {
                i++;
            }
            else
            {
                return [i + 1, j + 1];
            }
        }
        return [0];
    }
}