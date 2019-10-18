using System;

namespace TestPartial
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bird b = new Bird(10, "hello");
            b.Add(10, 20);
        }
    }
    partial class Bird
    {
        public string bird_name;
        public int a;
        public Bird(int _a, string _bName)
        {
            a = _a;
            bird_name = _bName;
        }
        partial void Print();
    }
}
