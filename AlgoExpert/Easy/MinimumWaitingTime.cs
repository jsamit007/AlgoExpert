namespace AlgoExpert.Easy;

internal class MinimumWaitingTime
{
    public int Calculate(int[] queries)
    {
        Array.Sort(queries);
        int totalWaitingTime = 0;

        int multiplier = queries.Length - 1;
        for (int i=0; i<queries.Length-1;i++)
            totalWaitingTime += queries[i] * multiplier--;

        return totalWaitingTime;
    }
}
