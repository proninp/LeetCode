namespace LeetCode.Medium._0875._Koko_Eating_Bananas.src;

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        var k = piles.Max();
        
        var left = 1;
        var right = k;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            long totalTime = 0;
            foreach (var p in piles)
                totalTime += (p + mid - 1) / mid;

            if (totalTime <= h)
            {
                k = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return k;
    }
}