using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class Client
    {
        public ConcreteFlyweight ConcreteFlyweight
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public UnsharedConcreteFlyweight UnsharedConcreteFlyweight
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public FlyweightFactory FlyweightFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
