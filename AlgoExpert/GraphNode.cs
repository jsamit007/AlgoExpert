namespace AlgoExpert;

public class GraphNode
{
    public string name;
    public List<GraphNode> children = new List<GraphNode>();

    public GraphNode(string name)
    {
        this.name = name;
    }

    public List<string> DepthFirstSearch(List<string> array)
    {
        array.Add(name);
        foreach (var child in children)
        {
            child.DepthFirstSearch(array);
        }
        return array;
    }

    public GraphNode AddChild(string name)
    {
        GraphNode child = new GraphNode(name);
        children.Add(child);
        return this;
    }
}
