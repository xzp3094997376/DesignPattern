using System;

namespace TestPartial.设计模式.结构型
{
    /// <summary>
    ///  桥接模式：
    ///  目标：应对排列组合变化。
    ///  解决方案：抽象应用分离。
    ///  有点：实现细节对用户透明
    ///  抽象保留对实例的引用
    /// </summary>
    class BridgeTest
    {
        static void Main(string[] args)
        {
            Abstraction rf = new RefineAbstraction(new ConCreatorImplementorA());
            rf.Operation();
            Console.ReadLine();
        }
    }
    interface IImplementor
    {
        void Operational();
    }
    class ConCreatorImplementorA : IImplementor
    {
        public void Operational()
        {
            Console.WriteLine("A具体实现");
        }
    }
    abstract class Abstraction
    {
        protected IImplementor imple;
        protected Abstraction(IImplementor ipe)
        {
            imple = ipe;
        }
        public abstract void Operation();
    }
    class RefineAbstraction : Abstraction
    {
        public RefineAbstraction(IImplementor imp) : base(imp)
        {

        }

        public override void Operation()
        {
            imple.Operational();
        }
    }

}
