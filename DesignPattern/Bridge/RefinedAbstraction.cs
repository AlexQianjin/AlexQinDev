using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            this.implementor.Operation();
        }
    }
}
