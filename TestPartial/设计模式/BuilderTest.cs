using System;

namespace TestPartial.设计模式
{
    class BuilderTest
    {
        static void Main(string[] args)
        {
            Builder bd = new ConcreteBuilder();
            Director dc = new Director(bd);
            dc.Construct().Show();
            Console.ReadLine();
        }
    }
    /// <summary>
    /// 同一产品
    /// </summary>
    class ProductA
    {
        public void SetPartA()
        {

        }
        public void SetPartB()
        {

        }
        public void Show()
        {
            Console.WriteLine("show");
        }
    }
    /// <summary>
    /// 抽象构造者
    /// </summary>
    abstract class Builder
    {
        protected ProductA pa = new ProductA();
        public abstract void BuildA();
        public abstract void BuildB();
        public ProductA GetResult()
        {
            return pa;
        }
    }
    /// <summary>
    /// 具体构建者
    /// </summary>
    class ConcreteBuilder : Builder
    {
        public override void BuildA()
        {
            Console.WriteLine("BuildA");
        }
        public override void BuildB()
        {
            Console.WriteLine("BuildB");
        }
    }
    /// <summary>
    /// 指挥者
    /// </summary>
    class Director
    {
        Builder builder;
        public Director(Builder _builder)
        {
            builder = _builder;
        }
        public ProductA Construct()
        {
            builder.BuildA();
            builder.BuildB();
            return builder.GetResult();
        }
    }
}
