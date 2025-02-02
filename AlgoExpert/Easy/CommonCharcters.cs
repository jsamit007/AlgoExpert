namespace AlgoExpert.Easy;

internal class CommonCharcters
{
    public string[] Find(List<string> str)
    {
        if (str.Count() > 0)
        {
            var set = str[0].ToHashSet();
            for (int i = 1; i < str.Count(); i++)
            {
                set = set.Intersect(str[i].ToHashSet()).ToHashSet();
            }
            var result = new string[set.Count()];
            int j = 0;
            foreach (var item in set)
                result[j++] = new string(item + "");
            return result;
        }
        return null;
    }
}
