using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
