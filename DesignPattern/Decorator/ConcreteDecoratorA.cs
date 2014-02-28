using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        protected string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            System.Console.WriteLine("具有装饰对象A的操作");
        }
    }
}
