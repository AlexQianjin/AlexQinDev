using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        /// <summary>
        /// 工厂模式(Factory Method)
        /// 定义一个用户创建对象的接口,
        /// 让子类决定实例化哪一个类。
        /// 工厂方法使一个类的实例化延迟到其子类。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Creator factory = new ConcreteCreator();
            Product product = factory.FactoryMethod();
            product.DoWork();

            Console.Read();
        }
    }
}
