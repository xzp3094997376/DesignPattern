using System;
using System.Collections.Generic;
using System.Text;

namespace TestPartial.设计模式.行为型
{
    /// <summary>
    /// 策略模式
    /// 不同策略，统一接口实现
    /// </summary>
    class Strategy
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("main");

            IStrategy isg = new ConcreteStrategyA();
            isg.StrategyMethod();

            isg = new ConcreteStrategyB();
            isg.StrategyMethod();

            Console.ReadLine();
        }
    }
    interface IStrategy
    {
       void StrategyMethod();
    }
    class ConcreteStrategyA:IStrategy
    {
        public void StrategyMethod()
        {
            Console.WriteLine("StrategyMethodA");
        }
    }

    class ConcreteStrategyB : IStrategy
    {
        public void StrategyMethod()
        {
            Console.WriteLine("StrategyMethodB");
        }
    }
    class Context
    {
        IStrategy strategy;
        public void SetStrategy(IStrategy stgy)
        {
            strategy = stgy;
        }
     
    }
}
