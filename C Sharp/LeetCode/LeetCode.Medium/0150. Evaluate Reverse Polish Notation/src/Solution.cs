namespace LeetCode.Medium._0150._Evaluate_Reverse_Polish_Notation.src;

public class Solution
{
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>(tokens.Length / 2 + 1);
        foreach (var token in tokens)
        {
            switch (token)
            {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case "-":
                    var b = stack.Pop();
                    var a = stack.Pop();
                    stack.Push(a - b);
                    break;
                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case "/":
                    var d = stack.Pop();
                    var c = stack.Pop();
                    stack.Push(c / d);
                    break;
                default:
                    stack.Push(FastParse(token));
                    break;
            }
        }
        return stack.Pop();
    }

    private int FastParse(string s)
    {
        var isNegative = s[0] == '-';
        var i = isNegative ? 1 : 0;
        var result = 0;
        for (; i < s.Length; i++)
        {
            result = result * 10 + (s[i] - '0');
        }
        return isNegative ? -result : result;
    }
}