using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            System.Console.WriteLine("具有装饰对象B的操作");

        }

        private void AddedBehavior()
        {
            System.Console.WriteLine("Added Behavior");
        }
    }
}
