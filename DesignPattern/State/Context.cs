using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class Context
    {
        private State state;

        public State State
        {
            get { return state; }
            set 
            {
                state = value;
                Console.WriteLine("当前状态：" + state.GetType().Name);
            }
        }

        public Context(State state)
        {
            this.state = state;
        }

        public void Request()
        {
            this.state.Handle(this);
        }
    }
}
