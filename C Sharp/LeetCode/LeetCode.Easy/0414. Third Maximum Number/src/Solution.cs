namespace LeetCode.Easy._0414._Third_Maximum_Number.src;

public sealed class Solution
{
    public int ThirdMax(int[] nums)
    {
        var max1 = long.MinValue;
        var max2 = long.MinValue;
        var max3 = long.MinValue;

        foreach (var x in nums)
        {
            if (x > max1)
            {
                max3 = max2; max2 = max1; max1 = x;
            }
            else if (x > max2 && x < max1)
            {
                max3 = max2; max2 = x;
            }
            else if (x > max3 && x < max2)
            {
                max3 = x;
            }
        }
        return (int)(max2 == long.MinValue || max3 == long.MinValue ? max1 : max3);
    }
}

