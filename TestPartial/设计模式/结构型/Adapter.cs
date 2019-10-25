using System;
namespace TestPartial.设计模式.结构型
{
    /// <summary>
    /// 适配器模式   客户 ：中间适配 ：已有组件
    /// </summary>
    class AdapterTest
    {
        static void Main1(string[] args)
        {
            ITarget tar = new ObjectAdapter(new Adaptee());
            tar.Request();
            Console.ReadLine();
        }
    }
    /// <summary>
    /// 目标接口
    /// </summary>
    interface ITarget
    {
        void Request();
    }
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("SpecificRequest");
        }
    }
    class ObjectAdapter : ITarget
    {
        Adaptee adpt;
        public ObjectAdapter(Adaptee _adpt)
        {
            adpt = _adpt;
        }
        public void Request()
        {
            Console.WriteLine("Object:adaptee");
            adpt.SpecificRequest();
        }
    }
}
