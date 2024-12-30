
namespace AlgoExpert;

internal class SpiralTraverse
{
    internal List<int> Traverse(int[,] matrix)
    {
        List<int> result = new();
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int sR = 0;
        int eR = rows-1;
        int sC = 0;
        int eC = cols-1;

        while(sR <= eC && eR >= sR)
        {
            for (int i = sC; i <= eC; i++)
                result.Add(matrix[sR, i]);

            for (int i = sR+1; i <= eR; i++)
                result.Add(matrix[i, eC]);

            for (int i = eC-1; i >= sC && eR != sR; i--)
                result.Add(matrix[eR, i]);

            for (int i = eR-1; i > sR && eC != sC; i--)
                result.Add(matrix[i, sC]);

            sR++;
            sC++;
            eR--;
            eC--;
        }
        return result;
    } 
}
