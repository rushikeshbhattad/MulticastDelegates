using System;

namespace MulticastDelegatesDemo
{
    public delegate void CalculateDelegate(int a, int b);
    public delegate void StringDelegate(string str);
    class Operations
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public void SubNums(int a, int b)
        {
            Console.WriteLine("Substraction: " + (a - b));
        }
        public void Greet(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with delegates:");
            Operations operations = new Operations();
            CalculateDelegate cd = new CalculateDelegate(operations.AddNums);
            cd += new CalculateDelegate(operations.SubNums);
            cd(10, 5);
            cd -= new CalculateDelegate(operations.AddNums);
            cd -= new CalculateDelegate(operations.SubNums);
            StringDelegate strd = new StringDelegate(operations.Greet);
            strd.Invoke("Hello");
            Console.ReadKey();
        }
    }
}