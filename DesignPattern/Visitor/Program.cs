using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        /// <summary>
        /// 访问者模式（Visitor）
        /// 表示一个作用于某对象结构中的各元素的操作，
        /// 它使你可以在不改变各元素的类的前提下定义作用于这些元素的新操作。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();

            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);

            Console.Read();
        }
    }
}
