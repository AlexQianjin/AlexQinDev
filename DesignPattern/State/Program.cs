using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        /// <summary>
        /// 状态模式（State）
        /// 当一个对象内在状态改变时允许改变其行为，
        /// 这个对象看起来像是改变了其类。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Console.Read();
        }
    }
}
