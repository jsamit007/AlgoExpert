using System.Xml.Linq;

namespace AlgoExpert;

internal class ReconstructBST<T> where T : IComparable<T>
{
    internal TreeNode<T> Create(T[] preOrder) 
    {
        //return FindTree(preOrder.ToArray(),0,preOrder.Length-1);
        int x = 0;
        return FindTreeOptimal(preOrder.ToArray(),int.MinValue,int.MaxValue,ref x);
    }

    internal TreeNode<T> FindTree(T[] list, int l,int r)
    {
        if (l > r)
            return default!;
        var node = new TreeNode<T>() { Value = list[l] };

        int rightIndexPos = r+1;
        for (int i = l + 1; i <= r; i++)
        {
            if (list[l].CompareTo(list[i]) < 0)
            {
                rightIndexPos = i;
                break;
            }
        }

        node.left = FindTree(list, l + 1, rightIndexPos - 1);
        node.right = FindTree(list, rightIndexPos, r);

        return node;
    }

    internal TreeNode<T> FindTreeOptimal(T[] list, int l, int r,ref int id)
    {
        if(id < list.Length && Convert.ToInt32(list[id]) >= l && Convert.ToInt32(list[id]) < r)
        {
            var node = new TreeNode<T>() { Value = list[id++] };
            node.left = FindTreeOptimal(list, l, Convert.ToInt32(node.Value),ref id);
            node.right = FindTreeOptimal(list, Convert.ToInt32(node.Value), r,ref id);
            return node;
        }
        return null!;
    }
}
