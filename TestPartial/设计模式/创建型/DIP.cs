using System;

namespace TestPartial.设计模式.依赖倒置原则
{
    //依赖抽象，具体实现
    class DIP
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("dsf");
            Customer c = new Customer();
            c.Buy(new Ashop());
            Console.ReadLine();
        }
    }

    interface Shop
    {
        void Sell();
    }

    /// <summary>
    /// 顾客销售
    /// </summary>
    class Customer
    {
        public void Buy(Shop shop)
        {
            shop.Sell();
        }
    }

    class Ashop : Shop
    {
        public void Sell()
        {
            Console.WriteLine("sell        Ashop");
        }
    }

    class Bshop : Shop
    {
        public void Sell()
        {
            Console.WriteLine("sell        Bshop");
        }
    }
}
