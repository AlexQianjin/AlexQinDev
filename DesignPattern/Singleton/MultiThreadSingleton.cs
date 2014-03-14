using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class MultiThreadSingleton
    {
        private static MultiThreadSingleton instance;
        private static readonly object syncRoot = new object();

        private MultiThreadSingleton()
        {
 
        }

        public static MultiThreadSingleton GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new MultiThreadSingleton();
                    }
                }
            }
            return instance;
        }
    }
}
