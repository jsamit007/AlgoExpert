namespace AlgoExpert.Medium;

internal class ZeroSumSubArray
{
    public bool Exist(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        set.Add(0);
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
            if (set.Contains(sum))
                return true;
            set.Add(sum);
        }
        return false;
    }
}
