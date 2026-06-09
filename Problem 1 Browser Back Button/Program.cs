using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        Stack<string> NextPages = new Stack<string>();
        Stack<string> PreviousPages = new Stack<string>();
        PreviousPages.Push("Page 1");
        PreviousPages.Push("Page 2");
        PreviousPages.Push("Page 3");
        PreviousPages.Push("Page 4");
        PreviousPages.Push("Page 5");
        ConsoleKeyInfo pressedKey;
        string CurrentPage = PreviousPages.Pop();
        while (true)
        {
            Console.WriteLine("------------------------------------------------");
            if (CurrentPage!="")
            {
                Console.WriteLine("Current Page Is: " + CurrentPage + " ");
            }
            Console.WriteLine("Press 0 to go back, and 1 to go forward");
            pressedKey = Console.ReadKey();
            Console.WriteLine();

            if(pressedKey.KeyChar - '0' == 0)
            {
                if (PreviousPages.Count > 0)
                {
                    NextPages.Push(CurrentPage);
                    CurrentPage = PreviousPages.Pop();
                }
                else
                {
                    Console.WriteLine("There Is No Pages To Go Back For, Press 1");
                }
            }
            else if(pressedKey.KeyChar - '0' == 1)
            {
                if (NextPages.Count > 0)
                {
                    PreviousPages.Push(CurrentPage);
                    CurrentPage = NextPages.Pop();
                }
                else
                {
                    Console.WriteLine("There Is No Pages To Go Forward, Press 0");
                }
            }
            else
            {
                Console.WriteLine("Invalid Key, Press 0 To Go Back, or 1 To Go Forward");
            }
            Console.WriteLine("------------------------------------------------");

        }
    }
}