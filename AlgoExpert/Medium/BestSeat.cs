namespace AlgoExpert.Medium;

internal class BestSeat
{
    public int Find(int[] seats)
    {
        int l = 0;
        int r = l+1;
        int maxSpace = 0;
        int bestSeat = -1;
        while (r < seats.Length)
        {
            if(seats[r] == 1)
            {
                int availableSpace = r - l - 1;
                if(availableSpace > maxSpace)
                {
                    maxSpace = availableSpace;
                    bestSeat = (l + r) / 2;
                }
                l = r;
            }
            r++;
        }
        return bestSeat;
    }
}
