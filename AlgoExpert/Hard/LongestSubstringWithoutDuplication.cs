namespace AlgoExpert.Hard;

internal class LongestSubstringWithoutDuplication
{
    public string Find(string str)
    {
        if(string.IsNullOrEmpty(str))
            return string.Empty;
        int i = 0;
        int j = 0;

        int max = 1;
        int start = 0;

        var charArray = str.ToCharArray();
        var map = new Dictionary<char, int>();

        while (i < charArray.Length && j < charArray.Length)
        {
            if (!map.ContainsKey(charArray[j]))
            {
                map.Add(charArray[j],j);
            }
            else
            {
                if (map[charArray[j]] < i)
                {
                    map[charArray[j]] = j;
                }
                else
                {
                    int length = j - i;
                    if (max < length)
                    {
                        max = length;
                        start = i;
                    }
                    i = map[charArray[j]] + 1;
                    map[charArray[j]] = j;
                }
            }
            if(j == charArray.Length - 1)
            {
                int length = j - i + 1;
                if (max < length)
                {
                    max = length;
                    start = i;
                }
            }
            j++;
        }

        return str.Substring(start, max);
    }
}
