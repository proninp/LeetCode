namespace LeetCode.Easy._0066._Plus_One.src;

public sealed class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var add = 1;
        var list = new List<int>(digits.Length);
        for (int i = digits.Length - 1;i >= 0; i--)
        {
            var d = digits[i] + add;
            add = 0;
            if (d > 9)
            {
                d -= 10;
                add++;
            }
            list.Add(d);
        }
        if (add > 0)
        {
            list.Add(add);
        }
        list.Reverse();
        return list.ToArray();
    }
}

