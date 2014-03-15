using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class ProductA1 : AbstractProductA
    {
        public override void DoWork()
        {
            Console.WriteLine("1系列 A");
        }
    }
}
