using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        /// <summary>
        /// 原型模式(Prototype)
        /// 用原型实例指定创建对象的种类，
        /// 并且通过拷贝这些原型创建新的对象
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            Console.Read();
        }
    }
}
