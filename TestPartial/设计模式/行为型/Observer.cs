using System;
using System.Collections.Generic;
using System.Text;

namespace TestPartial.设计模式.行为型
{
    /// <summary>
    /// 观察者模式
    /// 目标注册移除观察者，行为改变通知观察者。
    /// 
    /// </summary>
    class ObserverTest
    {
        static void Main(String[] args)
        {

            Subject sb= new ConcreteSubject();
            sb.Add(new ConcreteObserverA());
            sb.Add(new ConcreteObserverB());

            sb.NotifyObsever();

            Console.ReadLine();
        }
    }

    interface IObserver
    {
        void Response();
    }

    class ConcreteObserverA : IObserver
    {
        public void Response()
        {
            Console.WriteLine("A");
        }
    }
    class ConcreteObserverB : IObserver
    {
        public void Response()
        {
            Console.WriteLine("B");
        }
    }

    abstract class Subject
    {
        protected List<IObserver> observerList = new List<IObserver>();

        public void Add(IObserver obs)
        {
            observerList.Add(obs);
        }
        public void Remove(IObserver iobj)
        {
            observerList.Remove(iobj);
        }

        public abstract void NotifyObsever();        
    }

    class ConcreteSubject:Subject
    {
        public override  void NotifyObsever()
        {
            foreach (IObserver item in observerList)
            {
                item.Response();
            }
        }
    }
}
