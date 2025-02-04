using System.Text;

namespace AlgoExpert;

internal class PrettyPrint
{
    internal static void Print<T>(List<T> list)
    {
        string value = string.Join(", ", list);
        Console.WriteLine("[ " + value + " ]");
    }

    internal static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) 
        { 
            for (int j = 0; j < matrix.GetLength(1); j++) 
            { 
                Console.Write(matrix[i, j] + " "); 
            } 
            Console.WriteLine(); 
        }
    }

    internal static void Print(List<List<int>> matrix)
    {
        for (int i = 0; i < matrix.Count; i++)
        {
            for (int j = 0; j < matrix[i].Count; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    internal static void Print(List<int[]> list)
    {
        Console.Write("[ ");
        foreach(var item in list)
        {
            Console.Write("[ " + string.Join(", ",item) + " ]");
        }
        Console.Write(" ]");
    }
}
