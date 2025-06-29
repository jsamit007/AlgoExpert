
namespace AlgoExpert.Medium;

internal class SplitBinaryTree
{
    public static int IFPossible(TreeNode<int> root)
    {
        int sum = Sum(root);
        if (sum % 2 != 0)
            return 0; 
        int desiredSum = sum / 2;
        return IFPossible(root, desiredSum).Item2 ? desiredSum : 0;
    }

    private static (int,bool) IFPossible(TreeNode<int> node,int desiredSum)
    {
        if(node == null)
            return (0, false);
        var (leftSum, leftCanBeSplit) = IFPossible(node.left, desiredSum);
        var (rightSum, rightCanBeSplit) = IFPossible(node.right, desiredSum);
        int currenSum = node.Value + leftSum + rightSum;

        return (currenSum, leftCanBeSplit || rightCanBeSplit || desiredSum == currenSum); 
    }

    private static int Sum(TreeNode<int> root)
    {
        if(root == null)
            return 0;
        return root.Value + Sum(root.left) + Sum(root.right);
    }
}
