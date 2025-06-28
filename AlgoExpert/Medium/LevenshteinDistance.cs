namespace AlgoExpert.Medium;

internal class LevenshteinDistance
{
    public static int Find(string source,string target)
    {
        return CalculateCost(source, target, InitializeMatrix(source.Length, target.Length));
    }

    private static int[,] InitializeMatrix(int row,int column)
    {
        int[,] matrix = new int[row+1,column+1];
        for (int i = 0; i <= row; i++)
        {
            matrix[i, 0] = i; // Cost of deletions
        }
        for (int j = 0; j <= column; j++)
        {
            matrix[0, j] = j; // Cost of insertions
        }
        return matrix;
    }

    private static int CalculateCost(string src,string dest, int[,] matrix)
    {
        int row = 1, column = 1;
        for(; row < matrix.GetLength(0); row++)
        {
            for(; column < matrix.GetLength(1); column++)
            {
                if (src[row-1] == dest[column-1])
                    matrix[row, column] = matrix[row - 1, column - 1];
                else
                    matrix[row, column] = Math.Min(Math.Min(matrix[row - 1, column - 1], matrix[row, column - 1]), matrix[row-1,column]) + 1;
            }
            column = 1;
        }
        return matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    }
}
