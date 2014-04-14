using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitorConcreteElementA(this);
        }

        public void OperationA()
        {
 
        }
    }
}
