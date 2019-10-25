using System;

namespace TestPartial.设计模式.结构型
{
    /// <summary>
    /// 装饰模式
    /// 给对象动态的增加一些功能,不改变原来类结构
    /// 桥接模式的延续
    /// </summary>
    class DecoratorTest
    {
        static void Main1(string[] args)
        {
            new ConcreteDecorator(new ConcreteComponent()).Operation();
            Console.ReadLine();
        }
    }
    // 抽象构件
    interface IComponent
    {
        void Operation();
    }
    //具体构件
    class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent");
        }
    }
    class ABDecoractor
    {
        IComponent icom;
        protected ABDecoractor(IComponent _ic)
        {
            icom = _ic;
        }
        public virtual void Operation()
        {
            icom.Operation();
        }
    }
    class ConcreteDecorator : ABDecoractor
    {
        public ConcreteDecorator(IComponent ic) : base(ic)
        {

        }
        public override void Operation()
        {
            base.Operation();
            AddFunc();
            Console.WriteLine("ABDecoractor::Operation");
        }
        void AddFunc()
        {
            Console.WriteLine("add func");
        }
    }
}
