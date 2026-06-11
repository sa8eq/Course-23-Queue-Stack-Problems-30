using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static Queue<int> SortQueue(Queue<int> queue)
    {
        List<int> list = new List<int>(queue);
        list.Sort();
        return new Queue<int>(list);
    }
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>(new[] { 5, 1, 3, 2, 4 });
        Console.WriteLine($"Queue Before Sorting: {string.Join(", ", queue)}");

        Console.WriteLine($"Queue After Sorting: {string.Join(", ", SortQueue(queue))}");
        
    }
}

