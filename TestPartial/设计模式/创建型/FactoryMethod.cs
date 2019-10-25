using System;

namespace TestPartial.设计模式
{
    class FactoryMethod
    {
        static void Main1(string[] args)
        {
            Fac1 fac = new Fac1();
            fac.CreateProduc1().Show();
            Console.ReadLine();
        }
    }
    /// <summary>
    /// 产品
    /// </summary>
    interface Product
    {
        void Show();
    }
    class ConcreteProduct : Product
    {
        public void Show()
        {
            Console.WriteLine("具体产品");
        }
    }
    interface AbstractFac
    {
        Product CreateProduc1();
    }
    class Fac1 : AbstractFac
    {
        public Product CreateProduc1()
        {
            return new ConcreteProduct();
        }
    }
}
