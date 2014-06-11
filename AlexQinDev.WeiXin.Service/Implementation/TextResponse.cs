using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlexQinDev.WeiXin.Service.Interfaces;
using AlexQinDev.WeiXin.Service.Strategy;
using AlexQinDev.WeiXin.Model;
using AlexQinDev.WeiXin.Infrastructure;

namespace AlexQinDev.WeiXin.Service.Implementation
{
    public class TextResponse : IResponse
    {
        public string GetResponse(string xml)
        {
            string result = string.Empty;
            HandlerContext context = null;

            AcceptTextMessage accept = XmlHelper.XmlDeserialize<AcceptTextMessage>(xml, System.Text.Encoding.UTF8);
            string content = accept.Content.ToString().Trim();
            switch (content)
            {
                case "1":
                    context = new HandlerContext(new TextOneHandler(accept));
                    break;
                case "2":
                    context = new HandlerContext(new TextTwoHandler(accept));
                    break;
                default:
                    break;
            }
            result = context.GetHandlerResult();

            return result;
        }
    }
}
