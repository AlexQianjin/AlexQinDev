using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitorConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0}被{1}访问", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitorConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0}被{1}访问", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
