namespace AlgoExpert.Medium;

internal class MergeOverlappingInterval
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        int i = 0;
        int j = 1;

        List<int[]> result = new List<int[]>();

        while (i < j && j < intervals.Length)
        {
            if (intervals[i][1] < intervals[j][0])
            {
                result.Add(new int[] { intervals[i][0], intervals[i][1] });
                i++;
                j++;
            }
            else 
            {
                intervals[j][0] = intervals[i][0];
                intervals[j][1] = Math.Max(intervals[i][1], intervals[j][1]);
                i = j;
                j++;
            }
        }
        result.Add(new int[] { intervals[i][0], intervals[i][1] });
        return result.ToArray();
    }
}
