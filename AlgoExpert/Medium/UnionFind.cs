namespace AlgoExpert.Medium;

internal class UnionFind
{
    Dictionary<int, int> parents = new Dictionary<int, int>();
    Dictionary<int, int> ranks = new Dictionary<int, int>();

    public void CreateSet(int x)
    {
        parents.Add(x, x);
        ranks.Add(x, 0);
    }

    /*public int? Find(int x)
    {
        if (!parents.ContainsKey(x))
            return null;
        while (parents.ContainsKey(x) && parents[x] != x) 
            x = parents[x];

        return x;
    }*/

    // Path Compression
    public int? Find(int x)
    {
        if (!parents.ContainsKey(x))
            return null;

        if (parents[x] != x)
            parents[x] = Find(parents[x]) ?? -1;

        return x;
    }

    public void Union(int x,int y)
    {
        int left = Find(x) ?? -1;
        int right = Find(y) ?? -1;

        if(left == -1 || right == -1)
            return;

        if (ranks[left] > ranks[right])
        {
            parents[right] = left;
            ranks[left]++;
            ranks.Remove(right);
        }
        else
        {
            parents[left] = right;
            ranks[right]++;
            ranks.Remove(left);
        }   
    }
}
