using System.Text;

namespace AlgoExpert;

internal class ReverseWordsInString
{
    internal string Reverse(string input)
    {
        List<KeyValuePair<string,int>> wordSpaces = new List<KeyValuePair<string,int>>();
        StringBuilder word = new StringBuilder();
        int spaceCount = 0;
        foreach(char ch in input)
        {
            if (char.IsWhiteSpace(ch) && word.Length > 0)
                spaceCount++;
            else if (spaceCount == 0)
                word.Append(ch);
            else
            {
                wordSpaces.Add(new KeyValuePair<string, int>(word.ToString(), spaceCount));
                word.Clear();
                word.Append(ch);
                spaceCount = 0;
            }
        }
        wordSpaces.Add(new KeyValuePair<string, int>(word.ToString(), spaceCount));
        word.Clear();

        if (wordSpaces[wordSpaces.Count - 1].Value > 0)
            word.Append(' ', wordSpaces[wordSpaces.Count - 1].Value);

        for (int i = wordSpaces.Count - 1; i >= 0; i--)
        {
            word.Append(wordSpaces[i].Key);
            if (i > 0)
                word.Append(' ', wordSpaces[i - 1].Value);
        }
        return word.ToString();
    }
}
