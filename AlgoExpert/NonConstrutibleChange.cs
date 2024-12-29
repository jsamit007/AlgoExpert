namespace AlgoExpert;

internal class NonConstrutibleChange
{
    public int NonChangeableAmout(int[] coins)
    {
        Array.Sort(coins);
        int change = 1;
        foreach(int coin in coins)
        {
            if (change >= coin)
                change += coin;
            else
                break;
        }
        return change;
    }  
}
