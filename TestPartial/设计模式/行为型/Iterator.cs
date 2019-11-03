using System;
using System.Collections.Generic;
using System.Text;

namespace TestPartial.设计模式.行为型
{
    /// <summary>
    /// 迭代器模式，给聚合对象添加迭代器，对外封闭。
    /// </summary>
    class IteratorTest
    {
        static void Main(string[] args)
        {
            IAggregate iag = new Aggregate();
            iag.Add("1");
            iag.Add("2");
            iag.Add("3");

            IIterator itr= iag.GetIterator();
           Console.WriteLine(itr.First());

            while (itr.HasNext())
            {
                Console.WriteLine(itr.Next());
            }

            Console.ReadLine();
        }
    }

    interface IIterator
    {
        object First();
        object Next();
        bool HasNext();        
    }
   class ConcreteIterator : IIterator
    {
        List<object> objList;
        int index = 0;
        public ConcreteIterator(List<object> _objList)
        {
            objList = _objList;
        }
        public object First()
        {
            index = 0;          
            return objList[index];
        }
        public object Next()
        {
            object obj = null;
            if (HasNext())
            {
                obj = objList[++index];
            }
            return obj;
        }

        public bool HasNext()
        {
            bool has = false;
            if (index < objList.Count - 1)
            {
                has = true;
            }
            return has;
        }
    }

    interface IAggregate
    {
        void Add(object obj);
        void Remove(object obj);
        IIterator GetIterator();
    }

    class Aggregate:IAggregate
    {
        List<object> objList = new List<object>();
        public void Add(object obj)
        {
            objList.Add(obj);
        }
        public void Remove(object obj)
        {
            objList.Remove(obj);
        }

        public IIterator GetIterator()
        {
            return new ConcreteIterator(objList);
        }
    }
}
