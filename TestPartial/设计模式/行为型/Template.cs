using System;
using System.Collections.Generic;
using System.Text;

namespace TestPartial.设计模式.行为型
{
    /// <summary>
    /// 模板方法,抽离骨架
    /// 骨架抽象
    /// </summary>
    class Template
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("main");
            Abstract ab = new Concrete();
            ab.TemplateMethod();
            Console.ReadLine();
        }
    }

    abstract class Abstract
    {
        public void TemplateMethod()
        {
            SpecifyMethod();
            Method1();
        }
        public void SpecifyMethod()
        {
            Console.WriteLine("s1");
        }
        public abstract void Method1();
    }

    class Concrete:Abstract
    {
        public override void Method1()
        {
            Console.WriteLine("method1");
        }
    }

}
