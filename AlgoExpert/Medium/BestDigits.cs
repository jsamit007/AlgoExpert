using System.Text;

namespace AlgoExpert.Medium;

internal class BestDigits
{
    public string Calculate(string number,int numDigits)
    {
        if(number == null || number.Length == 0)
            return string.Empty;
        Stack<char> stack = new Stack<char>();
        stack.Push(number[0]);
        var array = number.ToCharArray();
        int i = 1;
        while (i < array.Length)
        {
            while(numDigits != 0 && stack.Count > 0 && stack.Peek() < array[i])
            {
                stack.Pop();
                numDigits--;
            }
            stack.Push(array[i]);
            i++;
        }

        while (numDigits-- > 0)
            stack.Pop();

        char[] sb = new char[stack.Count];
        i = stack.Count - 1;
        foreach (var ch in stack)
            sb[i--] = ch;

        return string.Join("",sb);
    }
}
