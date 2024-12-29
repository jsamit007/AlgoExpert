namespace AlgoExpert;

internal class GenerateDocument
{
    internal bool IsDocGenerationPossible(string characters,string document)
    {
        if (characters.Length < document.Length)
            return false;

        Dictionary<char, int> charFrequency = new Dictionary<char, int>();
        foreach (char c in characters)
        {
            if (charFrequency.ContainsKey(c))
                charFrequency[c]++;
            else
                charFrequency[c] = 1;
        }

        foreach (char c in document)
        {
            if (charFrequency.TryGetValue(c, out int count) && count > 0)
            {
                charFrequency[c]--;
            }
            else
            {
                return false; 
            }
        }

        return true; 
    }
}
