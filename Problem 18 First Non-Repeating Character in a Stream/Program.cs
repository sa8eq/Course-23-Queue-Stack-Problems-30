using System;
using System.Collections.Generic;

class Program
{
    static void FindFirstNonRepeating(string stream)
    {
        Dictionary<char, int> countMap = new Dictionary<char, int>();
        Queue<char> queue = new Queue<char>();
        foreach (char ch in stream)
        {
            if (!countMap.ContainsKey(ch))
            {
                countMap[ch] = 0;
            }
            countMap[ch]++;
            queue.Enqueue(ch);
            while (queue.Count > 0 && countMap[queue.Peek()] > 1)
            {
                queue.Dequeue();
            }
            Console.WriteLine(queue.Count > 0 ? queue.Peek() : '-');
        }
    }
    static void Main()
    {
        FindFirstNonRepeating("aabc");
        // Output: a, -, b, c
        Console.ReadKey();
    }
}
