using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class Product
    {
        public virtual void DoWork()
        {
            Console.WriteLine("父类 干活");
        }
    }
}
