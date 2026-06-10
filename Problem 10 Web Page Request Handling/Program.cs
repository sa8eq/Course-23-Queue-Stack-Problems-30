using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> requests = new Queue<string>();
        requests.Enqueue("Request 1");
        requests.Enqueue("Request 2");
        requests.Enqueue("Request 3");
        requests.Enqueue("Request 4");
        requests.Enqueue("Request 5");
        requests.Enqueue("Request 6");

        Console.WriteLine("Handling Requests...");
        while (requests.Count > 0)
        {
            string comingrequest = requests.Dequeue();
            Console.WriteLine($"{comingrequest} Recieved");
        }
    }
}

