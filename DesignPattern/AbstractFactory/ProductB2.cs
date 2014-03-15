using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class ProductB2 : AbstractProductB
    {
        public override void DoWork()
        {
            Console.WriteLine("2系列 B");
        }
    }
}
