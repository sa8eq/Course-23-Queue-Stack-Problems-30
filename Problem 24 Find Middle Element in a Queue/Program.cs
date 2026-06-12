using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static int FindMiddle(Queue<int> queue)
    {
        List<int> list = new List<int>(queue);
        return list[list.Count / 2];
    }

    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Console.WriteLine($"Middle Element In Queue Is: {FindMiddle(queue)}");
    }
}

