using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class ConcreteStateC : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateC();
        }
    }
}
