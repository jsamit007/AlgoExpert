namespace AlgoExpert;

internal class BinarySearchTree<T> where T : IComparable<T>
{
    internal TreeNode<T> Create(List<T> list) 
    {
        TreeNode<T> root = default!;

        foreach (T item in list)
            Add(ref root, item);

        return root;
    }

    internal void Add(ref TreeNode<T> rootNode, T item)
    {
        var temp = rootNode;
        if (rootNode != null)
        {
            while (temp.left != null || temp.right != null)
            {
                if (temp.Value.CompareTo(item) > 0)
                {
                    if (temp.left != null)
                        temp = temp.left;
                    else
                        break;
                }
                else
                {
                    if (temp.right != null)
                        temp = temp.right;
                    else
                        break;
                }
            }
            var node = new TreeNode<T>() { Value = item };
            if (temp.Value.CompareTo(item) > 0)
                temp.left = node;
            else
                temp.right = node;
        }
        else
            rootNode = new TreeNode<T>() { Value = item };
    }
}
