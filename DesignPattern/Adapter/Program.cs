using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        /// <summary>
        /// 适配器模式(Adapter)
        /// 将一个类的接口转换成客户希望的另一个接口。
        /// Adapter模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.Read();
        }
    }
}
