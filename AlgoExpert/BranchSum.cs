namespace AlgoExpert;

internal class BranchSum
{
    internal List<int> CalculateAll(TreeNode<int> root)
    {
        var list = new List<int>();
        Sum(root, 0, list);
        return list;
    }

    private void Sum(TreeNode<int> root,int count,List<int> sumList)
    {
        if(root != null)
        {
            count += root.Value;
            if(root.left != null) 
                Sum(root.left, count, sumList);
            if(root.right != null)
                Sum(root.right, count, sumList);

            if(root.left == null && root.right == null)
                sumList.Add(count);
        }
    }
}
