namespace AlgoExpert;

internal class TwoNumberSum
{
    public int[] FindPairs(int[] array,int key)
    {
        List<int> result = new List<int>();
        HashSet<int> set = new HashSet<int>();

        foreach (int i in array) 
        {
            if (set.Contains(key - i))
            {
                result.Add(i);
                result.Add(key - i);
            }
            else
                set.Add(i);
        }
        return result.ToArray();
    }
}
