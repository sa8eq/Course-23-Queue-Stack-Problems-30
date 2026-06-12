using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static string ReverseString(string str)
    {
        string rstr = "";
        Stack<char> rr = new Stack<char>();
        foreach(char i in str)
        {
            rr.Push(i);
        }
        while(rr.Count>0)
        {
            rstr += rr.Pop();
        }
        return rstr;
    }
    static void Main(string[] args)
    {
        string str = "hello";
        Console.WriteLine($"Reversed string Of (hello) is: {ReverseString(str)}");
    }
}

