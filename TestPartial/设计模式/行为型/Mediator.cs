using System;
using System.Collections.Generic;
using System.Text;

namespace TestPartial.设计模式.行为型
{
    /// <summary>
    /// 中介者注册保留通讯录，所有对象引用终结者广播
    /// 房子中介
    /// </summary>
    class MediatorTest
    {
        static void Main1(string[] args)
        {
            Mediator md = new ConcreteMediator();
            ConcreteColleagueA ca= new ConcreteColleagueA();
            ConcreteColleagueB cb= new ConcreteColleagueB();

            md.Register(ca);
            md.Register(cb);

            ca.Send();

            Console.ReadLine();
        }
    }

    abstract class Colleague
    {
        protected Mediator md;
        public void SetMediator(Mediator _md)
        {
            md = _md;
        }
        public abstract void Receive();
        public abstract void Send();

    }

    class ConcreteColleagueA:Colleague
    {
        public override void Receive()
        {
            Console.WriteLine("A:Receive");
            //throw new NotImplementedException();
        }

        public override void Send()
        {
            Console.WriteLine("A:Send");
            md.Relay(this);
            //throw new NotImplementedException();
        }
    }


    class ConcreteColleagueB : Colleague
    {
        public override void Receive()
        {
            Console.WriteLine("B:Receive");
            //throw new NotImplementedException();
        }

        public override void Send()
        {
            Console.WriteLine("B:Send");
            md.Relay(this);
            //throw new NotImplementedException();
        }
    }


    abstract class Mediator
    {
        public abstract void Register(Colleague cg);
        public abstract void Relay(Colleague cg);
    }
    class ConcreteMediator:Mediator
    {
        List<Colleague> cgList = new List<Colleague>();
        /// <summary>
        /// 注册receiver
        /// </summary>
        /// <param name="clg"></param>
        public  override void Register(Colleague clg)
        {
            if (!cgList.Contains(clg))
            {
                cgList.Add(clg);
                clg.SetMediator(this);
            }
        }

        /// <summary>
        /// 广播
        /// </summary>
        /// <param name="cg"></param>
        public override  void Relay(Colleague cg)
        {
            foreach (Colleague item in cgList)
            {
                if (!item.Equals(cg))
                {
                    item.Receive();
                }
            }
        }
    }
}
