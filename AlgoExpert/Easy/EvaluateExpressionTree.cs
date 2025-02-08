namespace AlgoExpert.Easy;

internal class EvaluateExpressionTree
{
    public int Evaluate(TreeNode<int> root)
    {
        if (root.left == null && root.right == null)
            return root.Value;

        var left = Evaluate(root.left);
        var right = Evaluate(root.right);

        if (root.Value == -1)
            return left + right;
        else if (root.Value == -2)
            return left - right;
        else if (root.Value == -3)
            return left / right;
        return left * right;
    }
}
