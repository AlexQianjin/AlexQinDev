using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        /// <summary>
        /// 中介者模式（Mediator）
        /// 用一个中介对象来封装一系列的对象交互。
        /// 中介者使各个对象不需要显示的相互引用，从而使其耦合松散，
        /// 而且可以独立的改变它们之间的交互
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("吃过饭了吗？");
            c2.Send("没有呢，你打算请客？");

            Console.Read();
        }
    }
}
