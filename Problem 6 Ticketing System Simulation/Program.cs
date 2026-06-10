using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ticketing System Simulation Started...\n");
        Queue<string> tickets = new Queue<string>();
        tickets.Enqueue("101");
        tickets.Enqueue("102");
        tickets.Enqueue("103");
        tickets.Enqueue("104");
        tickets.Enqueue("105");
        tickets.Enqueue("106");

        while(tickets.Count>0)
        {
            Console.WriteLine("------------------------------------");
            string currentTicket = tickets.Dequeue();
            Console.WriteLine($"Processing : {currentTicket}\n");
            if(tickets.Count>0)
            {
                Console.WriteLine($"Remaining Tickets: {string.Join(", ", tickets)}\n");
            }
            else
            {
                Console.WriteLine("There Is No More Tickets To Process...\n");
            }
        }
        Console.WriteLine("Ticketing System Simulation Ended...");
    }
}

