namespace AlgoExpert;

internal class NodeDepth
{
    internal int FindDepth(TreeNode<int> root)
    {
        return FindDepth(root, 0);
    }

    private int FindDepth(TreeNode<int> root,int depth)
    {
        if(root != null)
            return depth + FindDepth(root.left,depth+1) + FindDepth(root.right, depth + 1);
        return 0;
    }
}
