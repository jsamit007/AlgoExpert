namespace AlgoExpert.Hard;

internal class MaximizeExpression
{
    internal int Calculate(int[] array)
    {
        var maxArray = new int[array.Length];
        int maxValue = int.MinValue;
        int lastRead = 0;

        for (int i=0; i<array.Length; i++)
        {
            maxValue = Math.Max(maxValue, array[i]);
            maxArray[i] = maxValue;
        }
        maxValue = int.MinValue;
        lastRead = maxArray[0];
        for (int i=1; i<array.Length; i++)
        {
            maxValue = Math.Max(maxValue, lastRead - array[i]);
            lastRead = maxArray[i];
            maxArray[i] = maxValue;
        }
        maxValue = int.MinValue;
        lastRead = maxArray[1];
        for (int i = 2; i < array.Length; i++)
        {
            maxValue = Math.Max(maxValue, lastRead + array[i]);
            lastRead = maxArray[i];
            maxArray[i] = maxValue;
        }
        maxValue = int.MinValue;
        lastRead = maxArray[2];
        for (int i = 3; i < array.Length; i++)
        {
            maxValue = Math.Max(maxValue, lastRead - array[i]);
            lastRead = maxArray[i];
            maxArray[i] = maxValue;
        }

        return maxValue;
    }
}
