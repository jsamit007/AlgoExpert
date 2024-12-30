namespace AlgoExpert;

internal class TransposeMatrix
{
    internal int[][] Transpose(int[][] matrix)
    {
        for(int i=0; i<matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                if(i != j)
                {
                    matrix[i][j] = matrix[i][j];
                }
            }
        }
        return matrix;
    }
}
