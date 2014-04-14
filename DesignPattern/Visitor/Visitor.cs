using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitorConcreteElementA(ConcreteElementA concreteElementA);

        public abstract void VisitorConcreteElementB(ConcreteElementB concreteElementB);
    }
}
