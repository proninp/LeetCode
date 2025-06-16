namespace LeetCode.Easy._0020._Valid_Parentheses.src;

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if(c is '(' or '[' or '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                    return false;
                var top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}