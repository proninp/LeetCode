namespace LeetCode.Easy._0094._Binary_Tree_Inorder_Traversal.src;

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        Traverse(result, root);
        return result;
    }

    private void Traverse(IList<int> list, TreeNode? node)
    {
        if (node == null) return;
        Traverse(list, node.left);
        list.Add(node.val);
        Traverse(list, node.right);
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}