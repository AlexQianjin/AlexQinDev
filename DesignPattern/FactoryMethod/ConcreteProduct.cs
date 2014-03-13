using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class ConcreteProduct : Product
    {
        public override void DoWork()
        {
            Console.WriteLine("子类 干活");
        }
    }
}
