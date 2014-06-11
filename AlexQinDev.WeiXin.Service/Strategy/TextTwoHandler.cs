using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlexQinDev.WeiXin.Model;
using AlexQinDev.WeiXin.Infrastructure;

namespace AlexQinDev.WeiXin.Service.Strategy
{
    public class TextTwoHandler : AbstractHandler
    {
        private AcceptTextMessage _accept;

        public TextTwoHandler(AcceptTextMessage accept)
        {
            _accept = accept;
        }

        public override string GetResult()
        {
            string result = string.Empty;
            Articles articles = new Articles();
            articles.Item.Add(new Article { Title = "小思妹", Description = "女神小思妹", PicUrl = "http://d.pcs.baidu.com/thumbnail/257482481319ad2b04985c8312102721?fid=3204499409-250528-1696172053&time=1389258327&rt=pr&sign=FDTAER-DCb740ccc5511e5e8fedcff06b081203-omPNoA4KS6gX8I3xGyaVPyyGdo8%3D&expires=8h&prisign=RK9dhfZlTqV5TuwkO5ihMQzlM241kT2YfffnCZFTaEPwOxHv/XxtwRXLxDSXMBba1Ms9seOiqT9/QffwI8K2Baw0mmLABRQNl51b/oS8+InqoadADmwcyikKawH2SpzFmVrGREiaH1zZ09BZiFo3CF7dwGcK/xIzj9971pKao/QALkDxW+JJC9zJS3FHk0o7q45NqZXuYZl9ILH8IdNHtKrjHQBSR0Q9&r=682484659&size=c850_u580&quality=100", Url = "http://115.29.47.210/" });

            result = WeiXinUtils.GetSendImageTextMessage(_accept.ToUserName, _accept.FromUserName, articles);

            return result;
        }
    }
}
