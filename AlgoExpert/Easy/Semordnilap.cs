using System.Text;

namespace AlgoExpert.Easy;

internal class Semordnilap
{
    public List<List<string>> Find(string[] words)
    {
        var result = new List<List<string>>();
        var set = new HashSet<string>();

        foreach(var word in words)
        {
            if(set.Contains(word))
            {
                result.Add(new List<string> { Reverse(word),word });
                set.Remove(word);
            }
            else
                set.Add(Reverse(word));
        }
        return result;
    }

    private string Reverse(string word)
    {
        var charArray = word.ToCharArray();
        var reverse = new StringBuilder();
        for(int i = charArray.Length-1; i>=0; i--)
            reverse.Append(charArray[i]);
        return reverse.ToString();
    }
}
