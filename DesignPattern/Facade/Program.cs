using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        /// <summary>
        /// 外观模式(Facade)
        /// 为子系统中的一组接口提供一个一致的界面，
        /// 此模式定义了一个高层接口，
        /// 这个接口使得这个子系统更加容易使用
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            Console.Read();
        }
    }
}
