using System;

namespace TestPartial.设计模式.结构型
{
    /// <summary>
    /// 外观模式
    /// 多个子系统引用，外部访问复杂，提供统一接口
    /// </summary>
    class FacadeTest
    {
        static void Main1(string[] args)
        {
            IFacade iFd = new FacadeA();
            iFd.Method1();
            Console.ReadLine();
        }
    }
    interface IFacade
    {
        void Method1();
        void Method2();
    }
    class FacadeA : IFacade
    {
        SubSys1 sub1;
        SubSys2 sub2;
        public FacadeA()
        {
            sub1 = new SubSys1();
            sub2 = new SubSys2();
        }
        public void Method1()
        {
            sub1.Method1();
            Console.WriteLine("method1");
        }
        public void Method2()
        {
            sub2.Method2();
            Console.WriteLine("method1");
        }
    }
    class SubSys1
    {
        public void Method1()
        {
            Console.WriteLine("method1");
        }
    }
    class SubSys2
    {
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
}
