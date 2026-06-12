using System;
using System.Collections.Generic;
class Program
{
    static Queue<int> CloneQueue(Queue<int> queue)
    {
        if (queue.Count == 0) return new Queue<int>();
        int front = queue.Dequeue();
        Queue<int> ClonedQueue = CloneQueue(queue);
        ClonedQueue.Enqueue(front);
        queue.Enqueue(front);
        return ClonedQueue;
    }
    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4 });
        Queue<int> clonedQueue = CloneQueue(queue);
        Console.WriteLine(string.Join(", ", clonedQueue));
        Console.WriteLine(string.Join(", ", queue));
        Console.ReadKey();
    }
}