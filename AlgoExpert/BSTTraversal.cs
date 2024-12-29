namespace AlgoExpert;

internal class BSTTraversal
{
    public List<T> PreOrder<T>(TreeNode<T> rootNode, List<T> list) where T : IComparable<T>
    {
        if(rootNode != null)
        {
            list.Add(rootNode.Value);
            PreOrder<T>(rootNode.left, list);
            PreOrder<T>(rootNode.right, list);
        }
        return list;
    }

    public List<T> InOrder<T>(TreeNode<T> rootNode, List<T> list) where T : IComparable<T>
    {
        if (rootNode != null)
        {
            InOrder<T>(rootNode.left, list);
            list.Add(rootNode.Value);
            InOrder<T>(rootNode.right, list);
        }
        return list;
    }


    public List<T> PostOrder<T>(TreeNode<T> rootNode, List<T> list) where T : IComparable<T>
    {
        if (rootNode != null)
        {
            PostOrder<T>(rootNode.left, list);
            PostOrder<T>(rootNode.right, list);
            list.Add(rootNode.Value);
        }
        return list;
    }
}
