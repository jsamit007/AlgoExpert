
namespace AlgoExpert.Hard;

internal class ShortestPath
{
    public string Calculate(string str)
    {
        var paths = str.Split("/");
        Stack<string> orders = new Stack<string>();

        foreach (var path in paths)
        {
            if (path == "..")
            {
                if (orders.Count() > 0)
                    orders.Pop();
            }
            else if (path != "." && path != "")
            {
                orders.Push(path);
            }
        }
        var result = string.Join("/", orders.Reverse());
        return str.StartsWith("/") ? "/" + result : result;
    }
}
