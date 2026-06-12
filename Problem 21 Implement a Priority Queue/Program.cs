using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    //Doctor Solution
    class PriorityQueue
    {
        private SortedDictionary<int, Queue<int>> queue = new SortedDictionary<int, Queue<int>>();
        public void Enqueue(int value, int priority)
        {
            if (!queue.ContainsKey(priority))
            {
                queue[priority] = new Queue<int>();
            }
            queue[priority].Enqueue(value);
        }
        public int? Dequeue()
        {
            if (queue.Count == 0) return null;
            int highestPriority = queue.Keys.Min();
            int value = queue[highestPriority].Dequeue();
            if (queue[highestPriority].Count == 0)
            {
                queue.Remove(highestPriority);
            }
            return value;
        }
    }
    //My Solution
    public class Queue
    {
        private SortedList<int,string> list { set; get; }
        public Queue()
        {
            list = new SortedList<int, string>();
        }
        public void Enqueue(string Ticket, int Priority)
        {
            list.Add(Priority, Ticket);
        }
        public string Dequeue()
        {
            if (list.Count > 0)
            {
                int lastIndex = list.Count - 1; 
                string returnvalue = list.Values[lastIndex];
                list.Remove(list.Keys[lastIndex]);
                return returnvalue;
            }
            else
            {
                return "Queue Is Empty Nothing To Dequeue";
            }
        }
        public void PrintQueue()
        {
            if (list.Count > 0)
            {
                foreach (var i in list)
                {
                    Console.WriteLine($"Ticket: {i.Value}, Priority: {i.Key}");
                }
            }
            else
            {
                Console.WriteLine("Queue Is Empty");
            }
        }
    }
    static void Main(string[] args)
    {
        Queue queue = new Queue();

        queue.Enqueue("Vip Ticket", 4);
        queue.Enqueue("Special Ticket", 3);
        queue.Enqueue("Normal Ticket", 2);
        queue.Enqueue("Normal Ticket", 1);


        queue.PrintQueue();

        Console.WriteLine($"Ticket {queue.Dequeue()} Has Been Processed");
        Console.WriteLine($"Ticket {queue.Dequeue()} Has Been Processed");

        queue.PrintQueue();
    }
}

