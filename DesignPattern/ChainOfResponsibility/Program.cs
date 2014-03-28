using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        /// <summary>
        /// 职责链模式（Chain of Responsibility）
        /// 使多个对象都有机会处理请求,从而避免请求的发送者和接收者之间的耦合关系，
        /// 将这个对象连成一条链，并沿着这条链传递该请求，直到有一个对象处理它为止。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.Read();
        }
    }
}
