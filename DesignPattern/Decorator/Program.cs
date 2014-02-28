using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 装饰模式(Decorator)：
    /// 动态的给一个对象添加一些额外的职责，
    /// 就增加功能来说，装饰模式比生成子类更为灵活。
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();

            Console.Read();
        }
    }
}
