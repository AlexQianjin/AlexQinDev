using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            System.Console.WriteLine("具体对象的操作");
        }
    }
}
