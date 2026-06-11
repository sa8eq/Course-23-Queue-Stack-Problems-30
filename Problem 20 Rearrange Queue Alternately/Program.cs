using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    public static Queue<int> ReArrange(Queue<int> queue1)
    {
        int q1c = queue1.Count;
        Queue<int> queue2 = new Queue<int>();
        for(int i = 0; i < q1c /2 ;i++)
        {
            queue2.Enqueue(queue1.Dequeue());
        }

        Stack<int> stack = new Stack<int>();
        while(queue1.Count>0)
        {
            stack.Push(queue1.Dequeue());
        }

        Queue<int> queue3 = new Queue<int>();
        while (queue2.Count > 0 && stack.Count > 0)
        {
            queue3.Enqueue(queue2.Dequeue());
            queue3.Enqueue(stack.Pop());
        }
        if (queue2.Count > 0)
        {
            queue3.Enqueue(queue2.Dequeue());
        }
        else if (stack.Count > 0)
        {
            queue3.Enqueue(stack.Pop());
        }
        return queue3;
    }
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        Console.WriteLine($"Queue After Rearranging it Alternately {string.Join(", ", ReArrange(queue))}");

    }
}

