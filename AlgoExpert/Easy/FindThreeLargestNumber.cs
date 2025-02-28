namespace AlgoExpert.Easy;

internal class FindThreeLargestNumber
{
    public int[] Find(int[] array)
    {
        int[] result = new int[3] { int.MinValue, int.MinValue, int.MinValue };

        foreach (var num in array)
        {
            if (result[2] < num)
            {
                result[0] = result[1];
                result[1] = result[2];
                result[2] = num;
            }
            else if (result[1] < num)
            {
                result[0] = result[1];
                result[1] = num;
            }
            else if(result[0] < num)
            {
                result[0] = num;
            }
        }

        return result;
    }
}
