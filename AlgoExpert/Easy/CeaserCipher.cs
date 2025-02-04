using System.Text;

namespace AlgoExpert.Easy;

internal class CeaserCipher
{
    public string Encrypt(string str, int key)
    {
        StringBuilder strb = new StringBuilder();
        int start = (int)'a' - 1;
        foreach (var ch in str)
        {
            int alpha = (ch - start + key) % 26;
            alpha = alpha == 0 ? start + 26 : alpha + start;
            strb.Append((char)alpha);
        }
            
        return strb.ToString();
    }
}
