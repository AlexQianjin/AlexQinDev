using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class ProductA2 : AbstractProductA
    {
        public override void DoWork()
        {
            Console.WriteLine("2系列 A");
        }
    }
}
