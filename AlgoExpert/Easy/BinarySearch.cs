namespace AlgoExpert.Easy;

internal class BinarySearch
{
    public int[] Find(int[,] matrix,int key)
    {
        int i = 0;
        int j = matrix.GetLength(1) - 1;

        while (i >= 0 && j >= 0)
        {
            if (matrix[i, j] == key)
                return new int[] { i, j };
            else if (matrix[i, j] > key)
                j--;
            else
                i++;
        }
        return new int[] { -1, -1 };
    }
}
