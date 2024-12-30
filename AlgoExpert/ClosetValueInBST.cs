namespace AlgoExpert;

internal class ClosetValueInBST
{
    internal int GetClosest(TreeNode<int> root,int key)
    {
        KeyValuePair<int, int> nodeDiffPair = new KeyValuePair<int, int>(0,int.MaxValue);
        while(root != null)
        {
            int currentDiff = Math.Abs(root.Value - key);
            if (nodeDiffPair.Value > currentDiff)
                nodeDiffPair = new KeyValuePair<int, int>(root.Value,currentDiff);

            if (key < root.Value)
                root = root.left;
            else
                root = root.right;
        }
        return nodeDiffPair.Key;
    }
}
