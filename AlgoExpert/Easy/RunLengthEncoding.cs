using System.Text;

namespace AlgoExpert.Easy;

internal class RunLengthEncoding
{
    public string Encode(string str)
    {
        var encoded = new StringBuilder();
        var charArray = str.ToCharArray();
        int i = 0;
        int j = 0;
        while(i < charArray.Length)
        {
            int count = 0;
            while (j < charArray.Length && charArray[i] == charArray[j])
            {
                j++;
                count++;
            }
            EncodeSingle(encoded, count, charArray[i]);
            i = j;
        }
        return encoded.ToString();
    }

    public void EncodeSingle(StringBuilder strb,int occurrence,char ch)
    {
        while(occurrence > 0)
        {
            if(occurrence > 9)
                strb.Append("9").Append(ch);
            else
                strb.Append(occurrence).Append(ch);
            occurrence -= 9;
        }
    }
}
