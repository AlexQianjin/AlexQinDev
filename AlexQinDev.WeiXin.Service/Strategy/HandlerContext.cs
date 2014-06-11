using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexQinDev.WeiXin.Service.Strategy
{
    public class HandlerContext
    {
        private AbstractHandler _handler;

        public HandlerContext(AbstractHandler handler)
        {
            _handler = handler;
        }

        public string GetHandlerResult()
        {
            return _handler.GetResult();
        }
    }
}
