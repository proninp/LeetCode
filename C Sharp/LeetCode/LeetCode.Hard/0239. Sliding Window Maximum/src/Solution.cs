namespace LeetCode.Hard._0239._Sliding_Window_Maximum.src;

public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var result = new List<int>(nums.Length > 2 ? nums.Length - 2 : 1);
        var deque = new LinkedList<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (deque.Count > 0 && deque.First!.Value <= i - k)
                deque.RemoveFirst();

            while (deque.Count > 0 && nums[deque.Last!.Value] <= nums[i])
                deque.RemoveLast();

            deque.AddLast(i);
            
            if (i >= k - 1)
                result.Add(nums[deque.First!.Value]);
        }
        return result.ToArray();
    }
}