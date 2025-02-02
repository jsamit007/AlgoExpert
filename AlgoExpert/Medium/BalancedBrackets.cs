namespace AlgoExpert.Medium
{
    internal class BalancedBrackets
    {
        public bool IsBalancedBrackets(string str)
        {
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>
            {
                { ')','(' },
                { '}','{'},
                { ']','['}
            };
            var listOfchars = new HashSet<char>(new char[]{ '(', ')', '{', '}', '[', ']' });
            // ([]){} -> true
            var stack = new Stack<char>();

            foreach(char ch in str)
            {
                if (!listOfchars.Contains(ch))
                    continue;
                if(stack.Count != 0)
                {
                    var peek = stack.Peek();
                    keyValuePairs.TryGetValue(ch, out char value);
                    if (peek == value)
                        stack.Pop();
                    else
                        stack.Push(ch);
                }
                else
                    stack.Push(ch);
            }

            return stack.Count == 0;
        }
    }
}
