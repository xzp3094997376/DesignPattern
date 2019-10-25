using System;

namespace TestPartial.设计模式.结构型
{
    /// <summary>
    /// 代理模式
    /// 提供代理控制对该对象得的访问-中介作用
    /// 优点：降低系统的耦合度
    /// </summary>
    class ProxyTest
    {
        static void Main1(string[] args)
        {
            Subject px = new Proxy();
            px.Request();
            Console.ReadLine();
        }
    }
    interface Subject
    {
        void Request();
    }
    class RealSubject : Subject
    {
        public void Request()
        {
            Console.WriteLine("request");
        }
    }
    class Proxy : Subject
    {
        RealSubject rs;
        public void Request()
        {
            if (rs == null)
            {
                rs = new RealSubject();
            }
            PreRequest();
            rs.Request();
            PostRequest();
            //Console.WriteLine("request");
        }
        public void PreRequest()
        {
            Console.WriteLine("之前处理");
        }
        public void PostRequest()
        {
            Console.WriteLine("之后处理");
        }
    }
}
