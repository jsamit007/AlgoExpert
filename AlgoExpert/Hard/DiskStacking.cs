namespace AlgoExpert.Hard;

public class DiskStacking
{
    public static List<int[]> CalculateOrderWithMaxHeight(List<int[]> disks)
    {
        if (disks == null || disks.Count == 0)
            return new List<int[]>();
        disks.Sort((a, b) => a[2].CompareTo(b[2]));
        var sequences = new List<int>(Enumerable.Repeat(-1,disks.Count));
        return BuildStack(disks, sequences, GetMaxHeightIndex(disks, sequences));
    }

    private static int GetMaxHeightIndex(List<int[]> disks, List<int> sequences)
    {
        if (disks == null || disks.Count < 2)
            return -1;
        int[] emptyDisk = new int[] { 0, 0, 0 };
        var heights = disks.Select(disk => disk[2]).ToList();
        var maxIndex = 0;
        for (int i = 0; i < disks.Count; i++)
        {
            for (int j = -1; j < i; j++)
            {
                var movingDisk = j == -1 ? emptyDisk : disks[j];
                var height = j == -1 ? 0 : heights[j];
                if (IsDiskStackable(movingDisk, disks[i]) && heights[i] <= height + disks[i][2])
                {
                    heights[i] = height + disks[i][2];
                    sequences[i] = j; // Store the index of the disk below the current disk
                    if (heights[maxIndex] <= heights[i])
                        maxIndex = i;
                }
            }
        }
        return maxIndex;
    }

    private static bool IsDiskStackable(int[] disk1, int[] disk2)
    {
        return disk1[0] < disk2[0] && disk1[1] < disk2[1] && disk1[2] < disk2[2];
    }

    private static List<int[]> BuildStack(List<int[]> disks, List<int> sequences, int maxIndex)
    {
        if (maxIndex == -1)
            return disks;

        List<int[]> result = new List<int[]>();
        while (maxIndex != -1)
        {
            result.Add(disks[maxIndex]);
            maxIndex = sequences[maxIndex];
        }
        result.Reverse();
        return result;
    }
}
