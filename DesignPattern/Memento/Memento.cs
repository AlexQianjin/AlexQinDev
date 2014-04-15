using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class Memento
    {
        private string state;

        public string State
        {
            get { return state; }
        }

        public Memento(string state)
        {
            this.state = state;
        }
    }
}
