namespace AlgoExpert.Hard;

internal class DijkstraAlgorithm
{
    public int[] FindAllShortestPath(int start, int[][][] edges)
    {
        var nodesCount = edges.Length;
        var visted = new bool[nodesCount];
        var shortedPath = new int[nodesCount];
        var visitedNodes = new List<int>();

        for (int i=0; i<nodesCount; i++)
            shortedPath[i] = int.MaxValue;

        shortedPath[start] = 0;

        while(visitedNodes.Count < nodesCount)
        {
            var minIndex = -1;
            var min = int.MaxValue;
            for (int i=0; i<nodesCount; i++)
            {
                if(min > shortedPath[i] && visted[i] == false)
                {
                    min = shortedPath[i];
                    minIndex = i;
                }
            }

            if(minIndex == -1)
                break;

            visted[minIndex] = true;
            visitedNodes.Add(minIndex);
            var edge = edges[minIndex];

            for(int i=0; i<edge.Length; i++)
            {
                var destEdge = edge[i][0];
                var weight = edge[i][1];

                shortedPath[destEdge] = Math.Min(shortedPath[destEdge], shortedPath[minIndex] + weight);
            }
        }
        for(int i=0; i < nodesCount; i++)
        {
            if (shortedPath[i] == int.MaxValue)
                shortedPath[i] = -1;
        }
        return shortedPath;
    }
}
