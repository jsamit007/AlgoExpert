namespace AlgoExpert;

internal class SortedSquareArray
{
    public int[] GetSuchArray(int[] array)
    {
        var suchArray = array.Select(x => Convert.ToInt32(Math.Pow(x, 2))).ToArray();
        Array.Sort(suchArray);
        return suchArray;
    }

    public int[] OptimalSolution(int[] array)
    {
        // -6 ,-3, 2, 4, 5
        int[] solution = new int[array.Length];
        int currentPos = array.Length - 1;
        int left = 0, right = array.Length-1;
        while (currentPos >= 0) 
        {
            int value = 0;
            if (Math.Abs(array[left]) > Math.Abs(array[right]))
            {
                value = array[left];
                left++;
            }
            else
            {
                value = array[right];
                right--;
            }
            solution[currentPos--] = value * value;
        }
        return solution;
    }
}
