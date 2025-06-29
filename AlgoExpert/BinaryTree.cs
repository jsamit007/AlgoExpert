namespace AlgoExpert;

internal class BinaryTree
{

    internal static TreeNode<int> Create(List<int> list,TreeNode<int> root)
    {
        Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();

        foreach(int item in list)
        {
            if (root == null)
            {
                root = new TreeNode<int> { Value = item };
                continue;
            }
            queue.Clear();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                var temp = queue.Dequeue();
                
                if(temp.left == null)
                {
                    temp.left = new TreeNode<int> { Value = item };
                    break;
                }
                else
                    queue.Enqueue(temp.left);

                if(temp.right == null)
                {
                    temp.right = new TreeNode<int> { Value = item };
                    break;
                }
                else
                    queue.Enqueue(temp.right);
            }
        }    
        return root;
    }

    internal static void InvertTree(TreeNode<int> root)
    {
        if(root == null)
            return;

        var temp = root.left;
        root.left = root.right;
        root.right = temp;

        InvertTree(root.left);
        InvertTree(root.right);
    }

    internal static int Depth(TreeNode<int> root, int diameter = 0)
    {
        if(root == null)
            return 0;

        int leftHeight = Depth(root.left);
        int rightHeight = Depth(root.right);
        int calculatedDiameter = leftHeight + rightHeight + 1;
        diameter = Math.Max(diameter, calculatedDiameter);
        return Math.Max(leftHeight, rightHeight) + 1;
    }

    internal static bool IsBalancedTree(TreeNode<int> root)
    {
        return GetHeight(root) != -1;
    }

    private static int GetHeight(TreeNode<int> node)
    {
        if (node == null)
            return 0;

        int leftHeight = GetHeight(node.left);
        if (leftHeight == -1) 
            return -1; // left subtree is unbalanced

        int rightHeight = GetHeight(node.right);
        if (rightHeight == -1) 
            return -1; // right subtree is unbalanced

        if (Math.Abs(leftHeight - rightHeight) > 1)
            return -1; // current node is unbalanced

        return Math.Max(leftHeight, rightHeight) + 1;
    }

    internal static TreeNode<int> Merge(TreeNode<int> tree1,TreeNode<int> tree2)
    {
        if(tree1! == null && tree2 == null)
            return null;
        if(tree1 == null)
            return tree2;
        if(tree2 == null)
            return tree1;

        TreeNode<int> node = new TreeNode<int>
        {
            Value = tree1.Value + tree2.Value,
            left = Merge(tree1.left, tree2.left),
            right = Merge(tree1.right, tree2.right)
        };

        return node;
    }

    internal static bool IsSymmetric(TreeNode<int> left, TreeNode<int> right)
    {
        if(left == null)
        if (left.Value == right.Value)
            return true;
        return IsSymmetric(left.left, right.right);
    }
}
