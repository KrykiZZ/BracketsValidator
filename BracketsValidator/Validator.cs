namespace BracketsValidator
{
    public class Validator
    {
        private readonly static Dictionary<char, char> _brackets = new()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' },
        };

        public static bool Validate(string input)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (IsClosingBracket(input[i]))
                {
                    if (_brackets[input[i]] != stack.Pop())
                        return false;
                }
                else stack.Push(input[i]);
            }

            return stack.Count == 0;
        }

        private static bool IsClosingBracket(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }
    }
}
