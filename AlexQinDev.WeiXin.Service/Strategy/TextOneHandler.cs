using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlexQinDev.WeiXin.Infrastructure;
using AlexQinDev.WeiXin.Model;

namespace AlexQinDev.WeiXin.Service.Strategy
{
    public class TextOneHandler : AbstractHandler
    {
        private AcceptMessage _accept;

        public TextOneHandler(AcceptMessage accept)
        {
            _accept = accept;
        }
        public override string GetResult()
        {
            string result = string.Empty;
            string content = MovieWord.GetInstance().GetRandomMovieWord();
            result = WeiXinUtils.GetSendTextMessage(_accept.ToUserName, _accept.FromUserName, content);

            return result;
        }
    }
}
