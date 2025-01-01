namespace AlgoExpert;

internal class MoveElementToEnd
{
    internal List<int> MoveElements(List<int> list,int toMove)
    {
        if(list.Count() >= 2)
        {
            int i = 0, j = 1;
            while (i < j && j < list.Count())
            {
                if (list[i] != toMove)
                {
                    if (i+1 == j)
                        j++;
                    i++;
                }
                else if (list[j] == toMove)
                    j++;
                else
                {
                    int temp = list[j];
                    list[j] = list[i];
                    list[i] = temp;
                    i++;
                    j++;
                }
            }
        }
        return list;
    }
}
