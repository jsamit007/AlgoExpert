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
}
