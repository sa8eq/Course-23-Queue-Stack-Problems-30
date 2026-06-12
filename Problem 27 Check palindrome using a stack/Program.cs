using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static bool IsPalindrome(string txt)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char i in txt)
        {
            stack.Push(i);
        }
        for (int i = 0; i < txt.Length / 2; i++)
        {
            if (txt[i]!=stack.Peek())
            {
                return false;
            }
            stack.Pop();
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"Is madam a Palindrome Word? {IsPalindrome("madam")}");
        Console.WriteLine($"Is car a Palindrome Word? {IsPalindrome("car")}");
        Console.WriteLine($"Is planet a Palindrome Word? {IsPalindrome("planet")}");
        Console.WriteLine($"Is kaak a Palindrome Word? {IsPalindrome("kaak")}");
    }
}

