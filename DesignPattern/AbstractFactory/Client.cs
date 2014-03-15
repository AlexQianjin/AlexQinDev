using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        public AbstractFactroy AbstractFactroy
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public AbstractProductA AbstractProductA
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public AbstractProductB AbstractProductB
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
