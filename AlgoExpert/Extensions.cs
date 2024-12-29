namespace AlgoExpert;

internal static class Extensions
{
    public static bool InBetween(this int number,int start, int end) 
    {
        return number > start && number <= end;
    } 
}
