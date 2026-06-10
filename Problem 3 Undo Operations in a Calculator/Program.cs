using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public class Calculator
    {
        public int CurrentResult { set; get; }
        private Stack<int> PreviousResults = new Stack<int>();
        public void Add(int num1, int num2)
        {
            PreviousResults.Push(CurrentResult);
            CurrentResult = num1 + num2;
        }
        public void Subtract(int num1, int num2)
        {
            PreviousResults.Push(CurrentResult);
            CurrentResult = num1 - num2;
        }
        public void Devide(int num1, int num2)
        {
            PreviousResults.Push(CurrentResult);
            CurrentResult = num1 / num2;
        }
        public void Multiply(int num1, int num2)
        {
            PreviousResults.Push(CurrentResult);
            CurrentResult = num1 * num2;
        }
        public int GetResult()
        {
            return CurrentResult;
        }
        public void Undo()
        {
            CurrentResult = PreviousResults.Pop();
        }
    }
    static void Main(string[] args)
    {
        Calculator calq = new Calculator();
        calq.Add(10,10);
        Console.WriteLine("Result 10 + 10 = " + calq.GetResult());

        calq.Add(50, 50);
        Console.WriteLine("Result 50 + 50 = " + calq.GetResult());

        calq.Add(100, 100);
        Console.WriteLine("Result 100 + 100 = " + calq.GetResult());

        calq.Undo();
        Console.WriteLine("Previous Result Is: " + calq.GetResult());
    }
}

