using System.Text;

namespace AlgoExpert.Hard;

public class UnderscorifyString
{
    public string Operate(string main,string subString)
    {
        if(string.IsNullOrEmpty(main) || string.IsNullOrEmpty(subString))
            return main;
        return ReplaceWithUnderScore(main,MergeIntervals(FindAllOccerrences(main, subString)));
    }

    /// <summary>
    /// Find All Occurrences of the substring in the main string
    /// </summary>
    /// <param name="main"></param>
    /// <param name="subString"></param>
    /// <returns></returns>
    private List<List<int>> FindAllOccerrences(string main,string subString)
    {
        List<List<int>> indexes = new List<List<int>>();
        int startIndex = 0;
        int currentIndex = 0;
        while ((currentIndex = main.IndexOf(subString, startIndex)) != -1)
        {
            indexes.Add(new List<int> {currentIndex, currentIndex + subString.Length });
            startIndex = currentIndex + 1;
        }
        return indexes;
    }

    /// <summary>
    /// To identify back to back or override occurrences of the substring in the main string
    /// </summary>
    /// <returns></returns>
    private List<List<int>> MergeIntervals(List<List<int>> indexes)
    {
        if(indexes != null && indexes.Count > 1)
        {
            int i = 0;
            int j = 1;
            while(j < indexes.Count)
            {
                if (indexes[j][0] <= indexes[i][1])
                {
                    indexes[i][1] = indexes[j][1];
                    indexes.RemoveAt(j);
                }
                else
                {
                    j++;
                    i++;
                }
            }
        }
        return indexes;
    }

    private string ReplaceWithUnderScore(string main,List<List<int>> indexes)
    {
        if(indexes == null || indexes.Count == 0) 
            return main;
        
        StringBuilder strb = new StringBuilder();
        int i = 0;
        foreach(var index in indexes)
        {
            while(true)
            {
                if (i == index[0] || i == index[1])
                {
                    strb.Append('_');
                    if(i < main.Length)
                        strb.Append(main[i]);
                }
                else
                {
                    if (i > index[1])
                        break;
                    strb.Append(main[i]);
                }
                i++;
            }
        }
        if(i < main.Length)
            strb.Append(main.Substring(i));
        return strb.ToString();
    }
}
