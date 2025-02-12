namespace AlgoExpert.Medium;

internal class SingleCycleCheck
{
    public bool IsCycleExist(int[] array)
    {
        int currentIdx = 0;
        int elementsVisited = 0;

        while (elementsVisited < array.Length)
        {
            elementsVisited++;
            if (elementsVisited > 1 && currentIdx == 0)
                return false;
            
            var jump = array[currentIdx];
            var nextIdx = (currentIdx + jump) % array.Length;
            currentIdx = nextIdx >= 0 ? nextIdx : nextIdx + array.Length;
        }
        return currentIdx == 0;
    }
}
