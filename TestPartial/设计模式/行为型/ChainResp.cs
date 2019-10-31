using System;
using System.Collections.Generic;
using System.Text;

namespace TestPartial.设计模式.行为型
{
    class ChainRespTest
    {
        static void Main(string[] args)
        {
            string msg = "A";
            Console.WriteLine("Main--------"+msg);
            Handler hd1= new ConcreteHandlerA();
            Handler hd2 = new ConcreteHandlerB();
            hd1.SetNext(hd2);
            hd1.HandRequest(msg);

            Console.ReadLine();
            
        }
    }
    abstract class Handler
    {
        Handler handler;
        public void SetNext(Handler _handler)
        {
            handler = _handler;
        }
        public Handler GetHandler()
        {
            return handler;
        }
        public abstract void HandRequest(string msg);     
    }

    class ConcreteHandlerA:Handler
    {
        public override void HandRequest(string msg)
        {
            Console.WriteLine("A");
            if (msg.Equals("A"))
            {
                Console.WriteLine("deal with a");
            }
            else
            {
                if (GetHandler()!=null)
                {
                    GetHandler().HandRequest(msg);
                }
                else
                {
                    Console.WriteLine("A");
                }
            }
        }
    }
    class ConcreteHandlerB : Handler
    {
        public override void HandRequest(string msg)
        {
            Console.WriteLine("B");
            if (msg.Equals("B"))
            {
                Console.WriteLine("deal with b");
            }
            else
            {
                if (GetHandler() != null)
                {
                    GetHandler().HandRequest(msg);
                }
                else
                {
                    Console.WriteLine("stop B");
                }
            }
        }
    }
}
