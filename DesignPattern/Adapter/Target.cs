using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求");
        }
    }
}
