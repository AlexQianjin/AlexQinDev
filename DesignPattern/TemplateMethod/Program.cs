using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        /// <summary>
        /// 模板方法模式（TemplateMethod）
        /// 定义一个操作中的算法骨架，而将一些步骤延迟到子类中。
        /// 模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AbstractClass c;

            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();

            Console.Read();
        }
    }
}
