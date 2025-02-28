namespace AlgoExpert.Hard
{
    internal class ZigZagMatrix
    {
        public List<int> Traverse(List<List<int>> array)
        {
            if (array == null || array.Count == 0)
                return new List<int>();

            int numRows = array.Count;
            int numCols = array[0].Count;
            List<int> result = new List<int>(numRows * numCols);

            int row = 0, col = 0;
            bool goingDown = true;

            while (row < numRows && col < numCols)
            {
                result.Add(array[row][col]);

                if (goingDown)
                {
                    if (col == 0 || row == numRows - 1)
                    {
                        goingDown = false;
                        if (row == numRows - 1)
                            col++;
                        else
                            row++;
                    }
                    else
                    {
                        row++;
                        col--;
                    }
                }
                else
                {
                    if (row == 0 || col == numCols - 1)
                    {
                        goingDown = true;
                        if (col == numCols - 1)
                            row++;
                        else
                            col++;
                    }
                    else
                    {
                        row--;
                        col++;
                    }
                }
            }

            return result;
        }
    }
}
