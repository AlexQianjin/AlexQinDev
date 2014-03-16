using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        /// <summary>
        /// 建造者模式(Builder)
        /// 将一个复杂对象的构建与它的表示分离，
        /// 使得同样的构建过程可以创建不同的表示
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.Read();
        }
    }
}
