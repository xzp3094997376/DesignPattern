using System;
using System.Collections.Generic;
namespace TestPartial.设计模式.结构型
{
    /// <summary>
    /// 享元模式：
    /// 共享的和非共享的调用分开
    /// </summary>
    class FlyweightTest
    {
        static void Main1(string[] args)
        {
            FlyFactory fac = new FlyFactory();
            IFlyweight ifw = fac.GetFlyweight("key:123");
            ifw.Operation(new UnShareFly("value:infor"));

            ifw = fac.GetFlyweight("key:456");
            ifw.Operation(new UnShareFly("value:infor"));

            Console.ReadLine();
        }
    }
    /// <summary>
    /// 非享元模式
    /// </summary>
    class UnShareFly
    {
        string infor;
        public UnShareFly(string _infor)
        {
            infor = _infor;
        }
        public string GetInfor()
        {
            return infor;
        }
        public void SetInfor(string _infor)
        {
            infor = _infor;
        }
    }


    interface IFlyweight
    {
        void Operation(UnShareFly us);
    }

    class ConreteFlyweight : IFlyweight
    {
        string key;
        public void Operation(UnShareFly usf)
        {
            Console.WriteLine("key 创建");
            Console.WriteLine(usf.GetInfor());
        }
        public ConreteFlyweight(string _key)
        {
            key = _key;
        }

    }

    class FlyFactory
    {
        Dictionary<string, IFlyweight> flys = new Dictionary<string, IFlyweight>();
        public IFlyweight GetFlyweight(string key)
        {
            IFlyweight fw;
            bool exist = flys.TryGetValue(key, out fw);
            if (exist)
            {
                Console.WriteLine("已经存在");
            }
            else
            {
                fw = new ConreteFlyweight(key);
                flys.Add(key, fw);
                Console.WriteLine("新建对象");
            }
            return fw;
        }
    }
}
