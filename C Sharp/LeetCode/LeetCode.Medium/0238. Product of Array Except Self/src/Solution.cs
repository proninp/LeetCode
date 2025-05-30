namespace LeetCode.Medium._0238._Product_of_Array_Except_Self.src;

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var answer = new int[nums.Length];
        answer[0] = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            answer[i] = nums[i - 1] * answer[i - 1];
        }
        
        var suffix = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= suffix;
            suffix *= nums[i];
        }
        return answer;
    }
}