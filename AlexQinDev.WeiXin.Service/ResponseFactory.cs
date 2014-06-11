using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using AlexQinDev.WeiXin.Service.Interfaces;
using AlexQinDev.WeiXin.Service.Implementation;
using AlexQinDev.WeiXin.Infrastructure;

namespace AlexQinDev.WeiXin.Service
{
    public class ResponseFactory
    {
        public static IResponse Create(string xml)
        {
            IResponse response = null;

            XElement x = XElement.Parse(xml);
            string type = x.Element("MsgType").Value;
            switch (type)
            {
                case "text":
                    response = new TextResponse();
                    break;
                case "event":
                    response = new EventResponse();
                    break;
                default:
                    break;
            }

            return response;
        }
    }
}
