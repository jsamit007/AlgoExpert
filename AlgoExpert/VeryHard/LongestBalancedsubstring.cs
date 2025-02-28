
namespace AlgoExpert.VeryHard;

internal class LongestBalancedsubstring
{
    public int Calculate(string str)
    {
        int opening = 0;
        int closing = 0;
        int max = 0;
        var charArray = str.ToCharArray();

        Action<char,Func<int,int,bool>> action = (ch, pr) =>
        {
            if (ch == '(')
                opening++;
            else
                closing++;

            if (opening == closing)
            {
                int length = 2 * opening;
                if (max < length)
                    max = length;
            }
            else
            {
                if (pr(opening,closing))
                {
                    opening = 0;
                    closing = 0;
                }
            }
        };
        for (int i=0; i<charArray.Length; i++)
        {
            action(charArray[i], (o, c) => o < c);
        }

        opening = 0;
        closing = 0;

        for (int i = charArray.Length-1; i >= 0; i--)
        {
            action(charArray[i], (o, c) => o > c);
        }

        return max;
    }
}
