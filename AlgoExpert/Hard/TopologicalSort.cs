
namespace AlgoExpert.Hard;

internal class TopologicalSort
{
    public List<int> IsJobPossible(List<int> jobs, List<int[]> deps)
    {
        List<int> jobOrder = new List<int>();
        Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();
        jobs.ForEach(job => graph.Add(job, new HashSet<int>()));
        deps.ForEach(dep => graph[dep[1]].Add(dep[0]));

        while (graph.Count > 0)
        {
            int lessdependencies = -1;
            foreach (var kvp in graph)
            {
                if (kvp.Value.Count == 0)
                {
                    lessdependencies = kvp.Key;
                    graph.Remove(kvp.Key);
                    break;
                }
            }

            if (lessdependencies == -1)
                return new List<int>();
            jobOrder.Add(lessdependencies);

            foreach (var kvp in graph)
                kvp.Value.Remove(lessdependencies);

        }
        return jobOrder;
    }

    public List<int> DAGMethod(List<int> jobs, List<int[]> deps)
    {
        return GetJobOrderIfPoosible(CreateGraph(jobs, deps));
    }

    private class Node
    {
        public int job;
        public List<Node> PreRequisite;
        public bool Visited;
        public bool Visiting;
    }

    private class Graph
    {
        public List<Node> Nodes;
        public Dictionary<int, Node> NodeMap;
    }

    private Graph CreateGraph(List<int> jobs, List<int[]> deps)
    {
        Graph graph = new Graph();
        graph.Nodes = new List<Node>();
        graph.NodeMap = new Dictionary<int, Node>();
        foreach (var job in jobs)
        {
            Node node = new Node();
            node.job = job;
            graph.Nodes.Add(node);
            graph.NodeMap.Add(job, node);
        }

        foreach (var dep in deps)
        {
            var firstNode = graph.NodeMap[dep[0]];
            var secondNode = graph.NodeMap[dep[1]];
            if(secondNode.PreRequisite == null)
                secondNode.PreRequisite = new List<Node> { firstNode };
            else
                secondNode.PreRequisite.Add(firstNode);
        }
        return graph;
    }

    private List<int> GetJobOrderIfPoosible(Graph graph)
    {
        var orders = new List<int>();
        var nodes = new List<Node>(graph.Nodes);

        while(nodes.Count > 0)
        {
            var node = nodes[nodes.Count - 1];
            nodes.RemoveAt(nodes.Count - 1);
            var isCycle = DFS(node, orders);
            if(!isCycle)
                return new List<int>();
        }
        
        return orders;
    }

    private bool DFS(Node node, List<int> orders)
    {
        if(node.Visited)
            return true;
        if(node.Visiting)
            return false;

        if(node.PreRequisite != null)
        { 
            node.Visiting = true;
            foreach (var pre in node.PreRequisite)
            {
                var isCycle = DFS(pre, orders);
                if (!isCycle)
                    return false;
            }
            node.Visiting = false;

        }
        node.Visited = true;
        orders.Add(node.job);
        return true;
    }
}

