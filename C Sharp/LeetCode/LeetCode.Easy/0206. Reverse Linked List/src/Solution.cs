namespace LeetCode.Easy._0206._Reverse_Linked_List.src;

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        var current = head;
        while (current != null)
        {
            var tmp =  current.next;
            current.next = prev;
            prev = current;
            current = tmp;
        }
        return prev;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}