using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlexQinDev.WeiXin.Service.Interfaces;
using AlexQinDev.WeiXin.Service.Strategy;
using AlexQinDev.WeiXin.Infrastructure;
using AlexQinDev.WeiXin.Model;

namespace AlexQinDev.WeiXin.Service.Implementation
{
    public class EventResponse : IResponse
    {
        public string GetResponse(string xml)
        {
            string result = string.Empty;
            HandlerContext context = null;

            AcceptSubscribeEvent accept = XmlHelper.XmlDeserialize<AcceptSubscribeEvent>(xml, System.Text.Encoding.UTF8);
            string eventType = accept.Event.ToString().Trim();
            switch (eventType)
            {
                case "subscribe":
                    context = new HandlerContext(new SubscribeHandler(accept));
                    break;
                default:
                    break;
            }
            result = context.GetHandlerResult();

            return result;
        }
    }
}
