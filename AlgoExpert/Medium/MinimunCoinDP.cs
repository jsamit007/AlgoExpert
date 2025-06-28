namespace AlgoExpert.Medium;

internal class MinimunCoinDP
{
    public static int CalculateMinCoins(int n, int[] denoms)
    {
        int[] possibleExchange = new int[n + 1];
        Array.Fill(possibleExchange, int.MaxValue); // Set all to "infinity"
        possibleExchange[0] = 0; // Base case

        foreach (var denom in denoms)
        {
            for (int i = denom; i <= n; i++)
            {
                if (possibleExchange[i - denom] != int.MaxValue)
                    possibleExchange[i] = Math.Min(possibleExchange[i], 1 + possibleExchange[i - denom]);
            }
        }
        return possibleExchange[n] == int.MaxValue ? -1 : possibleExchange[n];
    }
}
