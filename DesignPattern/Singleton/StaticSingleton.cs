using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class StaticSingleton
    {
        private static StaticSingleton instance = new StaticSingleton();

        private StaticSingleton()
        {
 
        }

        public static StaticSingleton GetInstance()
        {
            return instance;
        }
    }
}
