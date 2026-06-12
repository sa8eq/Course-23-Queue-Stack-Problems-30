using System;
using System.Collections.Generic;
class BalancedParentheses
{
    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in input)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if(stack.Count==0)
                {
                    return false;
                }
                char top = stack.Pop();
                if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                {
                    return false;
                }
            }
            
        }
        return stack.Count == 0;
    }
    static void Main()
    {
        string input = "({[]})";
        Console.WriteLine($"Is \"{input}\" balanced? {IsBalanced(input)}");
        input = "({[)]}";
        Console.WriteLine($"Is \"{input}\" balanced? {IsBalanced(input)}");
        Console.ReadKey();
    }
}
