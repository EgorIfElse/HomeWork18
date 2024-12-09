internal class Program
{
    private static void Main(string[] args)
    {
        string input = "}{d(cc[])vvvd(fdbd)}";
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '{' || c == '[' || c == '(')

            {
                stack.Push(c);
            }
            else if (c == '}' || c == ']' || c == ')')
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("Cкобки расставлены некорректно");
                    return;
                }

                char open = stack.Pop();


                if (!((c == '}' && open == '{') || (c == ']' && open == '[') || (c == ')' && open == '(')))
                {

                    Console.WriteLine("Скобки расставлены некорректно");

                }
            }
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("Отлично");
        }
        else
        {
            Console.WriteLine("Скобки расставлены некорректно");
        }
    }
                










}
