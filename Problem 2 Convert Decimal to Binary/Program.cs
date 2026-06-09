using System;
using System.Collections.Generic;

internal class Program
{
    static string DecimalToBinary(int number)
    {
        if (number == 0) return "0";
        Stack<int> stack = new Stack<int>();
        while (number > 0)
        {
            stack.Push(number % 2);
            number /= 2;
        }
        return string.Join("", stack);
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enter A Number To Convert To Binary:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int decimalNumber) && decimalNumber >= 0)
            {
                Console.WriteLine($"You entered: {decimalNumber}");
                string binaryResult = DecimalToBinary(decimalNumber);
                Console.WriteLine($"The Binary of {decimalNumber} After Converting is: {binaryResult}");
            }
            else
            {
                Console.WriteLine("\nInvalid input! Please enter a valid positive integer.");
            }
        }
    }
}

