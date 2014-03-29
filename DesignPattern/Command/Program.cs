using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        /// <summary>
        /// 命令模式（Command）
        /// 将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化，
        /// 对请求排队或记录请求日志，以及支持可以撤销的操作
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker i = new Invoker();

            i.SetCommand(c);
            i.ExecuteCommand();

            Console.Read();
        }
    }
}
