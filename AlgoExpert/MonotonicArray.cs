namespace AlgoExpert;

internal class MonotonicArray
{
    internal bool IsMonotonic(int[] array)
    {
        bool result = true;
        if (array.Length > 1)
        {
            bool? isIncreasing = null;
            for (int i = 1; i < array.Length; i++)
            {
                if (isIncreasing == null)
                {
                    if (array[i] > array[i - 1])
                        isIncreasing = true;
                    else if (array[i] < array[i - 1])
                        isIncreasing = false;
                }
                else
                {
                    if ((isIncreasing == true && array[i] < array[i - 1]) || (isIncreasing == false && array[i] > array[i - 1]))
                    {
                        result = false;
                        break;
                    }
                }
            }
        }
        return result;
    }

    internal bool OptimalIsMonotonic(int[] array)
    {
        bool isIncresing = true;
        bool isDecresing = true;
        for(int i=0; i<array.Length-1; i++)
        {
            if (array[i] > array[i+1])
                isDecresing = false;
            if (array[i+1] > array[i])
                isIncresing = false;
        }
        return isDecresing || isIncresing;
    }
}
