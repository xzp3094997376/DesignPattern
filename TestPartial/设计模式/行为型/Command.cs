using System;
using System.Collections.Generic;
using System.Text;

namespace TestPartial.设计模式.行为型
{
    /// <summary>
    /// 命令模式
    ///cmd层将命令发送和执行者解耦
    /// </summary>
    class CommandTest   
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main");
            ICommand cmd=new ConcreteCmd();
            new Invoker(cmd).Call();
            Console.ReadLine();
        }
    }
    interface ICommand
    {
        void Execute();
    }
    class ConcreteCmd:ICommand
    {
        Receiver receiver;
        public ConcreteCmd()
        {
            receiver = new Receiver();
        }
        public void Execute()
        {
            Console.WriteLine("exe");
            receiver.Action();
        }
    }
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("action");
        }
    }
    class Invoker
    {
        ICommand cmd;
        public Invoker(ICommand _cmd)
        {
            cmd = _cmd;
        }
        public void Call()
        {
            cmd.Execute();
        }
    }
}
