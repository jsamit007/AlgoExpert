namespace AlgoExpert.Medium;

internal class MinimumCharactersForWords
{
    private class CharCount
    {
        public int Current { get; set; }
        public int Upper { get; set; }

        public CharCount(int current, int upper)
        {
            Current = current;
            Upper = upper;
        }
    }
    public string[] GetMinChars(string[] words)
    {
        var dict = new Dictionary<char, CharCount>();
        var result = new List<string>();
        foreach (var word in words)
        {
            foreach (var ch in word)
            {
                if (dict.ContainsKey(ch))
                {
                    var charCount = dict[ch];
                    charCount.Current++;
                    if (charCount.Upper < charCount.Current)
                    {
                        charCount.Upper++;
                    }
                }
                else
                {
                    dict.Add(ch, new CharCount(1, 1));
                }
            }

            foreach (var key in dict.Keys.ToList())
            {
                dict[key].Current = 0;
            }
        }

        foreach (var key in dict.Keys)
        {
            var occurrence = dict[key].Upper;
            while (occurrence > 0)
            {
                result.Add(key.ToString());
                occurrence--;
            }
        }
        return result.ToArray();
    }
}
