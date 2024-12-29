namespace AlgoExpert;

internal class ValidateSubsequence
{
    public bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        int i = 0, j = 0;
        int countMatched = 0;
        int arrayLength = array.Count;
        int sequenceLength = sequence.Count;

        while (i < arrayLength && j < sequenceLength)
        {
            if (array[i] == sequence[j])
            {
                countMatched++;
                j++;
            }
            i++; 
        }
        return countMatched == sequenceLength;
    }
}
