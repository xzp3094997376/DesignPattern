using System;

namespace TestPartial
{
    partial class Bird
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
            Print();
        }
        partial void Print()
        {
            Console.WriteLine("print  " + a + ",  " + bird_name);
            Console.ReadLine();
        }
    }
}
