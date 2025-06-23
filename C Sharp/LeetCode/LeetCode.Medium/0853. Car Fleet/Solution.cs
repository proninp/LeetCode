namespace LeetCode.Medium._0853._Car_Fleet;

public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var len = position.Length;
        var times = new float[target + 1];
        for (var i = 0; i < len; i++)
        {
            times[position[i]] = (float)(target - position[i]) / speed[i];
        }
        float prevTime = 0;
        var fleetCount = 0;
        for (var i = times.Length - 1; i >= 0; i--)
        {
            if (times[i] > prevTime)
            {
                prevTime = times[i];
                fleetCount++;
            }
        }
        return fleetCount;
    }
}