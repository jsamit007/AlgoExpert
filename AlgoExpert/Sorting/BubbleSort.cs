namespace AlgoExpert.Sorting;

internal class BubbleSort
{
    public static int[] Sort(int[] array)
    {
        for(int i=0; i<array.Length-1; i++)
        {
            bool isSwapped = false;
            for(int j = 0; j<array.Length-1-i; j++)
            {
                if (array[j] > array[j+1])
                {
                    Swap(array, j, j+1);
                    isSwapped = true;
                }
            }
            if (!isSwapped)
                break;
        }
        return array;
    }
    private static void Swap(int[] array, int i, int j)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
