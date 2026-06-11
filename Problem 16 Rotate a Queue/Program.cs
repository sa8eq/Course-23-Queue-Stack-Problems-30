using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static void RotateQueue(Queue<int> queue, int n)
    {
        for (int i = 0; i < n; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }
    }
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
        Console.WriteLine($"Queue Before Rotation: {string.Join(", ", queue)}");
        RotateQueue(queue, 2);
        Console.WriteLine($"Queue After Rotation: {string.Join(", ", queue)}");
    }
}

