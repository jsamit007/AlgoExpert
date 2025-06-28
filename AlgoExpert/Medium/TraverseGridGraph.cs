namespace AlgoExpert.Medium;

internal class TraverseGridGraph
{
    public static int NoOfWays(int width, int height)
    {
        int[,] grid = new int[height, width];
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                if (i == 0 || j == 0)
                    grid[i, j] = 1; // Base case: first row and first column
                else
                    grid[i, j] = grid[i - 1, j] + grid[i, j - 1]; // Sum of ways from top and left
            }
        }
        return grid[height - 1, width - 1]; // Return the bottom-right corner value
    }

    public static int FormulaWay(int width, int height)
    {
        return Factorial(width + height - 2) / (Factorial(width - 1) * Factorial(height - 1));
    }

    private static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }
}
