namespace AlgoExpert.Medium;

internal class TaskAssignment
{
    public List<List<int>> AssignTasks(int k, List<int> tasks)
    {
        var result = new List<List<int>>();
        Dictionary<int, Stack<int>> posMap = new Dictionary<int, Stack<int>>();
        int i = 0;
        for (i = 0; i < tasks.Count; i++)
        {
            if (posMap.ContainsKey(tasks[i]))
                posMap[tasks[i]].Push(i);
            else
            {
                posMap.Add(tasks[i], new Stack<int>(new int[] { i }));
            }
        }
        tasks.Sort();
        int j = tasks.Count - 1;
        i = 0;
        while(i < j)
            result.Add(new List<int> { posMap[tasks[i++]].Pop(), posMap[tasks[j--]].Pop() });
        return result;
    }
}
