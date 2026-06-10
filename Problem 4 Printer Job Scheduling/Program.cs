using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> tasks = new Queue<string>();
        tasks.Enqueue("Task 1");
        tasks.Enqueue("Task 2");
        tasks.Enqueue("Task 3");
        tasks.Enqueue("Task 4");
        tasks.Enqueue("Task 5");
        tasks.Enqueue("Task 6");
        tasks.Enqueue("Task 7");
        tasks.Enqueue("Task 8");
        tasks.Enqueue("Task 9");
        tasks.Enqueue("Task 10");
        tasks.Enqueue("Task 11");

        while(tasks.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Processing: {tasks.Dequeue()}");
            Console.WriteLine($"Next Task Is: {tasks.Peek()}");
            Thread.Sleep(1000);
        }
    }
}

