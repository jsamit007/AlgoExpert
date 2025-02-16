namespace AlgoExpert.Medium;

internal class KadanesAlgo
{
    public int FindMaxSum(int[] array)
    {
        int maxSoFar = array[0];
        int maxEndingHere = array[0];

        for(int i=1; i<array.Length; i++)
        {
            maxEndingHere = Math.Max(array[i], maxEndingHere + array[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }
        return maxSoFar;
    }
}
