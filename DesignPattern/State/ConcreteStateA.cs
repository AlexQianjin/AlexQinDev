using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
