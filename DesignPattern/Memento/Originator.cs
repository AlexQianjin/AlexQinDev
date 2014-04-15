using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public Memento CreateMemento()
        {
            return (new Memento(state));
        }

        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("State=" + state);
        }
    }
}
