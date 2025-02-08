namespace AlgoExpert.Easy;

internal class FirstNonRepeatingCharacter
{
    public int Find(string str)
    {
        if(str == "")
            return -1;
        Dictionary<char,int> map = new Dictionary<char, int>();

        var chars = str.ToCharArray();
        var max = chars.Length;

        for (int i = 0; i < chars.Length; i++)
        {
            if (map.ContainsKey(chars[i]))
                map[chars[i]] = max;
            else
                map.Add(chars[i], i);
        }
        var index = map.Values.Min();
        return index == max ? -1 : index;
    }
}
