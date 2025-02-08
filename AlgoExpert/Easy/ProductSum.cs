namespace AlgoExpert.Easy;

internal class ProductSum
{
    public int CalculateProductSum(List<object> array)
    {
        return CalculateProductSum(array, 1);
    }

    private int CalculateProductSum(List<object> array,int count)
    {
        int result = 0;
        foreach (var item in array)
        {
            if (item is List<object>)
            {
                count++;
                result += CalculateProductSum((List<object>)item, count) * count;
                count--;
            }
            else
                result += (int)item;
        }
        return result;
    }
}

