namespace AlgoExpert;

internal class ThreeNumberSum
{
    internal List<int[]> FindAllTriplet(int[] array,int targetSum)
    {
        Array.Sort(array);
        var result = new List<int[]>();
        for(int i = 0; i < array.Length-2; i++)
        {
            int left = i + 1;
            int right = array.Length - 1;

            while(left < right)
            {
                int currentSum = array[left] + array[right] + array[i];

                if (currentSum == targetSum)
                {
                    result.Add(new[] { array[i] , array[left], array[right] });
                    left++;
                    right--;
                }
                else if (currentSum < targetSum)
                    left++;
                else
                    right--;
            }
        }
        return result;
    }
}
