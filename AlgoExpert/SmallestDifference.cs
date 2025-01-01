namespace AlgoExpert;

internal class SmallestDifference
{
    internal int[] CalculateDifference(int[] arrayOne, int[] arrayTwo)
    {
        return OptiamlCalulateDiff(arrayOne, arrayTwo);
    }

    private int[] CalulateDiff(int[] minArray, int[] maxArray,bool first)
    {
        int min = int.MaxValue;
        int[] list = new int[2];
        for (int i = minArray.Length-1; i>=0; i--)
        {
            for(int j = maxArray.Length-1; j>=0; j--)
            {
                if (Math.Abs(minArray[i] - maxArray[j]) > min)
                    break;
                min = Math.Abs(minArray[i] - maxArray[j]);
                if(first)
                {
                    list[0] = minArray[i];
                    list[1] = maxArray[j];
                }
                else
                {
                    list[0] = maxArray[j];
                    list[1] = minArray[i];
                }
                    
            }
        }
        return list;
    }

    private int[] OptiamlCalulateDiff(int[] arrayOne, int[] arrayTwo)
    {
        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);

        int min = int.MaxValue;
        int[] list = new int[2];
        int i = 0;
        int j = 0;

        while (i < arrayOne.Length && j < arrayTwo.Length)
        {
            if (Math.Abs(arrayOne[i] - arrayTwo[j]) < min)
            {
                min = Math.Abs(arrayOne[i] - arrayTwo[j]);
                list[0] = arrayOne[i];
                list[1] = arrayTwo[j];
            }
            if (arrayOne[i] < arrayTwo[j])
                i++;
            else
                j++;
        }
        return list;
    }
}
