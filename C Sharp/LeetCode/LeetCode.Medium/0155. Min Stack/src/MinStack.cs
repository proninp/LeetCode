namespace LeetCode.Medium._0155._Min_Stack.src;

public class MinStack
{
    private Stack<(int Val, int Min)> _stack;
    
    public MinStack() {
        _stack = new Stack<(int, int)>();
    }
    
    public void Push(int val)
    {
        var min = _stack.Count > 0 ? _stack.Peek().Min : int.MaxValue;
        _stack.Push((val, Math.Min(min, val)));
    }
    
    public void Pop() {
        _stack.Pop();
    }
    
    public int Top() {
        return _stack.Peek().Val;
    }
    
    public int GetMin() {
        return _stack.Peek().Min;
    }
}