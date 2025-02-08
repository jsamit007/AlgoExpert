namespace AlgoExpert.Medium;

internal class LongestPeak
{
    public int FindLongestPeak(int[] array)
    {
        int longestPeak = 0;
        int length = array.Length;

        if (length < 3)
            return longestPeak;

        int s = 1;
        length--;
        while (s < length)
        {
            var isPeak = array[s - 1] < array[s] && array[s] > array[s + 1];
            if(isPeak)
            {
                int left = s - 1;
                int right = s + 1;

                while (left >= 0 && array[left] < array[left + 1])
                    left--;

                while (right <= length && array[right - 1] > array[right])
                    right++;

                longestPeak = Math.Max(longestPeak, right - left - 1);
                s = right;
                continue;
            }
            s++;
        }
        return longestPeak;
    }
}
