namespace AlgoExpert;
internal class PalindromeCheck
{
    internal bool IsPalindrome(string str)
    {
        int l = 0;
        int r = str.Length - 1;
        while (l < r)
        {
            if (str[l++] == str[r--])
                continue;
            return false;
        }
        return true;
    }
}
