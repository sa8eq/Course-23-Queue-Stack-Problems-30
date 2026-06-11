using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public static bool IsPalindrome(Queue<int> nums)
    {
        
        Stack<int> numsstack = new Stack<int>();

        foreach (var i in nums)
        {
            numsstack.Push(i);
        }

        foreach (var i in nums)
        {
            if (numsstack.Pop() != i)
            {
                return false; 
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(1);
        nums.Enqueue(2);
        nums.Enqueue(3);
        nums.Enqueue(2);
        nums.Enqueue(1);

        Console.WriteLine($"Is Queue Palindrome? {IsPalindrome(nums)}");
    }
}

