using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    public abstract class Prototype
    {
        private string id;

        public string Id
        {
            get { return id; }
        }

        public Prototype(string id)
        {
            this.id = id;
        }

        public abstract Prototype Clone();
    }
}
