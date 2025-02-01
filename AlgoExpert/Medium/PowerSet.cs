namespace AlgoExpert.Medium;

internal class PowerSet
{
    public List<List<int>> GeneratePowerSet(List<int> list)
    {
        List<List<int>> result = new List<List<int>>();
        var sublist = new List<int>();
        result.Add(sublist);
        foreach(var elem in list)
        {
            int count = result.Count;
            for (int i=0; i<count; i++)
            {
                sublist = new List<int>(result[i]);
                sublist.Add(elem);
                result.Add(sublist);
            }
        }
        return result;
    }

    public List<List<int>> GeneratePowerRecursive(List<int> list)
    {
        return GeneratePowerSetRecursive(list,null!);
    }

    public List<List<int>> GeneratePowerSetRecursive(List<int> list,List<List<int>> result = null!,int id = int.MinValue)
    {
        if(id == int.MinValue)
            id = list.Count - 1;
        else if(id < 0)
            return new List<List<int>> { new List<int>() };
        var elem = list[id];
        result = GeneratePowerSetRecursive(list, result, id - 1);
        int count = result.Count;
        for (int i = 0; i < count; i++)
        {
            var sublist = new List<int>(result[i]);
            sublist.Add(elem);
            result.Add(sublist);
        }
        return result;
    }
}
