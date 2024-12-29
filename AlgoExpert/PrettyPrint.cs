namespace AlgoExpert;

internal class PrettyPrint
{
    internal static void Print(List<int> list)
    {
        string value = string.Join(", ", list);
        Console.WriteLine("[ " + value + " ]");
    }
}
