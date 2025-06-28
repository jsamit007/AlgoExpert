namespace AlgoExpert.Medium;

internal class MaxSubsetSum
{
    public static int Calculate(int[] array)
    {
        if (array == null || array.Length == 0)
            return 0;
        int first = array.Length >= 1 ? array[0] : 0;
        int second = array.Length >= 2 ? Math.Max(array[0], array[1]) : first;

        for (int i = 2; i < array.Length; i++)
        {
            array[i] = Math.Max(second, first + array[i]);
            first = second;
            second = array[i];
        }
            
        return Math.Max(first,second);
    }
}
