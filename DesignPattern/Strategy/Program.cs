using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        /// <summary>
        /// 策略模式（Strategy）
        /// 它定义了算法家族，分别封装起来，让他们之间可以互相替换,
        /// 此模式让算法的变化，不会影响到使用算法的客户
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.Read();
        }
    }
}
