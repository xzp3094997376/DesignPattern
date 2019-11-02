using System;
using System.Collections.Generic;
using System.Text;

namespace TestPartial.设计模式.行为型
{
    /// <summary>
    /// /状态模式
    /// 环境-状态-具体
    /// 抽象应对不同变化
    /// </summary>
    class StateTest
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("main");

            SContext st= new SContext();

            st.SetState(new ConcreteStateA());
            st.Handle();

            st.SetState(new ConcreteStateB());
            st.Handle();

            Console.ReadLine();
        }
    }

    abstract class State
    {
        public abstract void Handle(SContext c);
    }
    class ConcreteStateA :State
    {
        public override void Handle(SContext c)
        {
            Console.WriteLine("A");
        }
    }
    class ConcreteStateB:State
    {
        public override void Handle(SContext c)
        {
            Console.WriteLine("B");
        }
    }
    internal class SContext
    {
        State state;
        public SContext()
        {

        }
        public void SetState(State _state)
        {
            state = _state;
        }
        public State GetState()
        {
            return state;
        }
        public void Handle()
        {
            state.Handle(this);
        }
    }
}
