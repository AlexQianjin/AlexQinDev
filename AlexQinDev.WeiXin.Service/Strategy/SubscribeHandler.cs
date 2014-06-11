using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlexQinDev.WeiXin.Model;
using AlexQinDev.WeiXin.Infrastructure;

namespace AlexQinDev.WeiXin.Service.Strategy
{
    public class SubscribeHandler : AbstractHandler
    {
        private AcceptMessage _accept;

        public SubscribeHandler(AcceptMessage accept)
        {
            _accept = accept;
        }
        public override string GetResult()
        {
            string result = string.Empty;
            string content = "你好！欢迎关注鲁巷骑行,单车带来更多快乐！";
            result = WeiXinUtils.GetSendTextMessage(_accept.ToUserName, _accept.FromUserName, content);

            return result;
        }
    }
}
