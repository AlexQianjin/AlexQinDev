using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        /// <summary>
        /// 观察者模式（Observer）
        /// 定义了一种一对多的关系，让多个观察者对象同时监听某一个主题对象。
        /// 这个主题对象在状态发生变化时，会通知所有观察者对象，使他们能够自动更新自己。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            s.Notify();

            Console.Read();
        }
    }
}
