using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitorConcreteElementB(this);
        }

        public void OperationB()
        {
 
        }
    }
}
