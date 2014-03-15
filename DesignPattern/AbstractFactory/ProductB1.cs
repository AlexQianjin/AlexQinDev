using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class ProductB1 : AbstractProductB
    {
        public override void DoWork()
        {
            Console.WriteLine("1系列 B");
        }
    }
}
