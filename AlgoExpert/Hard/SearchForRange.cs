namespace AlgoExpert.Hard;

internal class SearchForRange
{
    public int[] Find(int[] array, int target)
    {
        int[] result = new int[2];
        result[0] = -1;
        result[1] = -1;
        Find(array, target, 0, array.Length - 1, result);
        return result;
    }
    public void Find(int[] array,int target, int l , int r, int[] result)
    {
        int mid = 0;

        while(l <= r)
        {
            mid = (l + r) / 2;

            if (array[mid] == target)
            {
                if (mid == 0)
                    result[0] = 0;
                else if (array[mid - 1] != target)
                    result[0] = mid;

                if (mid == array.Length-1)
                    result[1] = array.Length - 1;
                else if (array[mid + 1] != target)
                    result[1] = mid;   

                if (result[0] == -1)
                    Find(array, target, l, mid - 1, result);
                if(result[1] == -1)
                    Find(array, target, mid + 1, r, result);
                break;
            }
            else if (array[mid] > target)
                r = mid - 1;
            else
                l = mid + 1;
        }
    }
}
