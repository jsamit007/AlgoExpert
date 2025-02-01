namespace AlgoExpert;

internal class EvaluateExpressionTree
{
    public int Evaluate(TreeNode<int> root)
    {
        Stack<TreeNode<int>> stack = new Stack<TreeNode<int>>();
        if(root != null)
            stack.Push(root);

        while (stack.Count > 0)
        {
            if(stack.Count == 1 && stack.Peek().Value > 0)
                return stack.Pop().Value;

            if (stack.Peek().Value < 0)
            {
                var node = stack.Peek();
                if(node.right != null)
                    stack.Push(node.right);
                if(node.left != null)
                    stack.Push(node.left);
            }
            else
            {
                var valNode = stack.Pop();
                var valnode1 = stack.Pop();
                var val1 = valNode.Value;
                var val2 = valnode1.Value;

                if (val2 > 0)
                {
                    var op = stack.Pop().Value;
                    if (op == -1)
                        val1 = val1 + val2;
                    else if (op == -2)
                        val1 = val1 - val2;
                    else if (op == -3)
                        val1 = val1 / val2;
                    else 
                        val1 = val1 * val2;

                    stack.Push(new TreeNode<int> { Value = val1 });
                }
                else
                {
                    stack.Push(valNode);
                    stack.Push(valnode1);
                }
            }
        }
        return -1;
    }
}
