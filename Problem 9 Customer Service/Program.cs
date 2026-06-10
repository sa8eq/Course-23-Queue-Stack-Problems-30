using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> customer = new Queue<string>();
        customer.Enqueue("Customer 1");
        customer.Enqueue("Customer 2");
        customer.Enqueue("Customer 3");
        customer.Enqueue("Customer 4");
        customer.Enqueue("Customer 5");
        customer.Enqueue("Customer 6");

        Console.WriteLine("Serving customers:\n");

        while (customer.Count > 0)
        {
            string currentCustomer = customer.Dequeue();
            Console.WriteLine($"Serving: {currentCustomer}");
        }
    }
}

