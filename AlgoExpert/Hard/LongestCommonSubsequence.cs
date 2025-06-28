
namespace AlgoExpert.Hard;

internal class LongestCommonSubsequence
{
    public static List<char> Find(string str1,string str2)
    {
        return BuildSequence(BuildMatrix(str1, str2));
    }

    private static List<char> BuildSequence(LCSNode[,] matrix)
    {
        var sequence = new List<char>();
        int row = matrix.GetLength(0) - 1;
        int col = matrix.GetLength(1) - 1;

        while(row != 0 && col != 0)
        {
            var node = matrix[row, col];
            if(node.Character != '\0')
                sequence.Add(node.Character);
            row = node.Row;
            col = node.Col;
        }
        sequence.Reverse();
        return sequence;
    }

    private static LCSNode[,] BuildMatrix(string str1,string str2)
    {
        var matrix = new LCSNode[str1.Length + 1,str2.Length + 1];
        for (int row = 0; row < matrix.GetLength(0); row++)
            matrix[row,0] = new LCSNode { Row = row, Col = 0};
        for(int col = 0; col < matrix.GetLength(1); col++)
            matrix[0,col] = new LCSNode { Row = 0, Col = col };

        for (int row = 1; row < matrix.GetLength(0); row++)
        {
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (str1[row-1] == str2[col-1])
                    matrix[row, col] = new LCSNode
                    {
                        Length = matrix[row - 1, col - 1].Length + 1,
                        Row = row-1,
                        Col = col-1,
                        Character = str1[row-1]
                    };
                else
                {
                    if (matrix[row - 1, col].Length > matrix[row, col - 1].Length)
                        matrix[row, col] = new LCSNode
                        {
                            Row = row - 1,
                            Col = col,
                            Length = matrix[row - 1, col].Length,
                        };
                    else
                        matrix[row, col] = new LCSNode
                        {
                            Row = row,
                            Col = col - 1,
                            Length = matrix[row, col - 1].Length,

                        };
                }
            }
        }
        return matrix;
    }

    private class LCSNode
    {
        public int Length = 0;
        public int Row;
        public int Col;
        public char Character = '\0';
    }
}
