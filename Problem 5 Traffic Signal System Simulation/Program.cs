using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> vehicles = new Queue<string>();

        vehicles.Enqueue("Car 1");
        vehicles.Enqueue("Truck 1");
        vehicles.Enqueue("Bike 1");
        vehicles.Enqueue("Bus 1");
        Console.WriteLine("Traffic Signal Simulation Started...\n");

        while (vehicles.Count > 0)
        {
            Console.WriteLine($"{vehicles.Dequeue()} Has Passed The Signal\n");
            if (vehicles.Count > 0)
            {
                Console.WriteLine("Vehicles waiting: " + string.Join(", ", vehicles) + "\n");
            }
            else
            {
                Console.WriteLine("No vehicles waiting.\n");
            }

        }

        Console.WriteLine("Traffic Signal Simulation Ended...");
    }
}

