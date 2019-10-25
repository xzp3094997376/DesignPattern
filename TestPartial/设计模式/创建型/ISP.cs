using System;
namespace TestPartial.设计模式
{
    class ISP
    {
        static void Main1(string[] args)
        {
            CountModule cm = new StudentInfor();
            cm.CountTotal();
            Console.ReadLine();

        }
    }
    /// <summary>
    /// 输入模块
    /// </summary>
    interface Input
    {
        void Insert();
    }
    /// <summary>
    /// 统计模块
    /// </summary>
    interface CountModule
    {
        void CountTotal();
    }
    /// <summary>
    ///输出信息模块
    /// </summary>
    interface PrintModule
    {
        void PrintInfor();
    }

    class StudentInfor : CountModule, Input, PrintModule
    {
        public void Insert()
        {
            Console.WriteLine("插入信息");
        }
        public void CountTotal()
        {
            Console.WriteLine("统计模块");
        }
        public void PrintInfor()
        {
            Console.WriteLine("打印信息");
        }
    }

}
