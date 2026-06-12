using System;
using System.Collections.Generic;


class Program
{
    static string RemoveInvalidParentheses(string s = "(())))))")
    {
        Stack<int> stack = new Stack<int>();
        HashSet<int> invalids = new HashSet<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]=='(')
            {
                stack.Push(i);
            }
            else if (s[i]==')')
            {
                if(stack.Count==0)
                {
                    invalids.Add(i);
                }
                else
                {
                    stack.Pop();
                }
            }
        }
        while(stack.Count>0)
        {
            invalids.Add(stack.Pop());
        }
        char[] result = new char[s.Length - invalids.Count];
        int index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(!invalids.Contains(i))
            {
                result[index] = s[i];
                index++;
            }
        }
        return new string(result);
    }
    static void Main()
    {
        Console.WriteLine(RemoveInvalidParentheses());
        Console.ReadKey();
    }
}
