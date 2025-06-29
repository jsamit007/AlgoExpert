namespace AlgoExpert.Sorting;

internal class InsertionSort
{
    public static int[] Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int current = array[i];
            int j = i - 1;

            // Move elements of array[0..i-1], that are greater than current,
            // to one position ahead of their current position
            while (j >= 0 && array[j] > current)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = current;
        }
        return array;
    }
}
