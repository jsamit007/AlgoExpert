namespace AlgoExpert.Hard;

internal class QuickSelect
{
    public static int  Find(int[] array,int k)
    {
        if (k > array.Length)
            return -1;
        int pivot = 0;
        int left = 0;
        int right = array.Length - 1;
        bool isFound = false;
        while (!isFound)
        {
            pivot = Partition(array, left, right);
            if (pivot == k-1) 
                isFound = true;
            else if (pivot < k - 1)
                left = pivot + 1;
            else
                pivot--;
        }
        return array[pivot];
    }

    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right]; // Use the last element as the pivot
        int partitionIndex = left;

        for (int i = left; i < right; i++)
        {
            if (array[i] <= pivot)
            {
                Swap(array, i, partitionIndex);
                partitionIndex++;
            }
        }

        Swap(array, partitionIndex, right); // Place the pivot in its correct position
        return partitionIndex;
    }

    private static void Swap(int[] array,int i, int j)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
