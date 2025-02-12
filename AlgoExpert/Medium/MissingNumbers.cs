namespace AlgoExpert.Medium;

internal class MissingNumbers
{
    public int[] FindUsingXOR(int[] nums)
    {
        int xor = 0;
        for(int i=1; i<=nums.Length+2; i++)
        {
            xor ^= i;
            if(i - 1 < nums.Length)
                xor ^= nums[i - 1];
        }
        var xorSol = new int[2];
        int setBit = xor & -xor;

        for(int i=1; i<=nums.Length+2;i++)
        {
            var temp = i & setBit;
            if (temp == 0)
                xorSol[0] ^= i;
            else
                xorSol[1] ^= i;

            if(i - 1 < nums.Length)
            {
                temp = nums[i - 1] & setBit;
                if (temp == 0)
                    xorSol[0] ^= nums[i - 1];
                else
                    xorSol[1] ^= nums[i - 1];
            }
        }
        Array.Sort(xorSol);
        return xorSol;
    }

    public int[] FindUsingSum(int[] nums)
    {
        int totalSum = (nums.Length + 2) * (nums.Length + 3) / 2;
        int average = (totalSum - nums.Sum()) / 2;

        var sumSol = new int[2];

        for (int i = 1; i <= nums.Length + 2; i++)
        {
            if (i <= average)
                sumSol[0] += i;
            else
                sumSol[1] += i;

            if (i - 1 < nums.Length)
            {
                if (nums[i - 1] <= average)
                    sumSol[0] -= nums[i - 1];
                else
                    sumSol[1] -= nums[i - 1];
            }
        }
        Array.Sort(sumSol);
        return sumSol;
    }
}
