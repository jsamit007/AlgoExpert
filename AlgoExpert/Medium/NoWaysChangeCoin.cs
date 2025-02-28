namespace AlgoExpert.Medium;

internal class NoWaysChangeCoin
{
    public int NoOfWays(int n, int[] denoms)
    {
        int[] amounts = new int[n+1];
        amounts[0] = 1;

        foreach (var denom in denoms)
        {
            for(int i = 0; i<amounts.Length; i++)
            {
                if(denom <= i)
                    amounts[i] += amounts[i - denom];
            }
        }

        return amounts[n];
    }
}
