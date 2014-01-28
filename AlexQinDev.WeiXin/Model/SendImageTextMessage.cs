using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AlexQinDev.WeiXin.Model
{
    [Serializable]
    [XmlType("xml")]
    public class SendImageTextMessage
    {
        public MyCDATA ToUserName { get; set; }

        public MyCDATA FromUserName { get; set; }

        public string CreateTime { get; set; }

        public MyCDATA MsgType { get; set; }

        public int ArticleCount { get; set; }

        public Articles Articles { get; set; }
    }

    [Serializable]
    public class Articles
    {
        public Articles()
        {
            this.Item = new List<Article>();
        }
        [XmlElement("item")]
        public List<Article> Item { get; set; }
    }

    [Serializable]
    public class Article
    {
        public MyCDATA Title { get; set; }
        public MyCDATA Description { get; set; }
        public MyCDATA PicUrl { get; set; }
        public MyCDATA Url { get; set; }
    }
}
