using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        /// <summary>
        /// 抽象工厂模式(Abstract Factory)
        /// 提供一个创建一系列相关或相互依赖对象的接口，
        /// 而无需指定它们具体的类
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AbstractFactroy factory1 = new ConcreteFactory1();
            AbstractProductA productA1 = factory1.CreateProductA();
            productA1.DoWork();
            AbstractProductB productB1 = factory1.CreateProductB();
            productB1.DoWork();

            AbstractFactroy factory2 = new ConcreteFactroy2();
            AbstractProductA productA2 = factory2.CreateProductA();
            productA2.DoWork();
            AbstractProductB productB2 = factory2.CreateProductB();
            productB2.DoWork();

            Console.WriteLine("short.MaxValue: {0}", short.MaxValue);
            Console.WriteLine("Int16.MaxValue: {0}", Int16.MaxValue);
            Console.WriteLine("Int16.MinValue: {0}", Int16.MinValue);
            Console.WriteLine("UInt16.MaxValue: {0}", UInt16.MaxValue);
            Console.WriteLine("UInt16.MinValue: {0}", UInt16.MinValue);
            Console.WriteLine("int.MaxValue: {0}", int.MaxValue);
            Console.WriteLine("Int32.MaxValue: {0}", Int32.MaxValue);
            Console.WriteLine("Int32.MinValue: {0}", Int32.MinValue);
            Console.WriteLine("UInt32.MaxValue: {0}", UInt32.MaxValue);
            Console.WriteLine("UInt32.MinValue: {0}", UInt32.MinValue);

            Console.Read();
        }
    }
}
