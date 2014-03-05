using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);

        public abstract void Remove(Component c);

        public abstract void Display(int depth);
    }
}
