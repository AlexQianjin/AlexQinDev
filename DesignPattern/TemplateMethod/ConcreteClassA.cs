using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体A类方法的1实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体A类方法的2实现");
        }
    }
}
