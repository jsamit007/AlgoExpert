namespace AlgoExpert;

internal class FirstDuplicateValue
{
    internal int FindDuplicate(int[] array)
    {
        for(int i=0; i<array.Length; i++)
        {
            int index = Math.Abs(array[i]) - 1;
            if (array[index] > 0)
                array[index] *= -1;
            else
                return Math.Abs(array[0]);
        }
        return array.Length == 1 ? Math.Abs(array[0]) : -1;
    }
}
