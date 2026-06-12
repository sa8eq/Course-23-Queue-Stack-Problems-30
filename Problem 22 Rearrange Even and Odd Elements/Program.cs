using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    public static void ReArrange(Queue<int> queue)
    {
        Queue<int> odd = new Queue<int>();
        Queue<int> even = new Queue<int>();

        while(queue.Count>0)
        {
            if(queue.Peek()%2==0)
            {
                even.Enqueue(queue.Dequeue());
            }
            else
            {
                odd.Enqueue(queue.Dequeue());
            }
        }
        while(even.Count>0)
        {
            queue.Enqueue(even.Dequeue());
        }
        while (odd.Count > 0)
        {
            queue.Enqueue(odd.Dequeue());
        }
    }
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Console.WriteLine($"Queue Before ReArranging Odd And Even Number: {string.Join(", ",queue)}");
        ReArrange(queue);
        Console.WriteLine($"Queue After ReArranging Odd And Even Number: {string.Join(", ", queue)}");

    }
}

