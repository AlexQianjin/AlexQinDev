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
    public class AcceptImageMessage
    {
        public MyCDATA ToUserName { get; set; }

        public MyCDATA FromUserName { get; set; }

        public string CreateTime { get; set; }

        public MyCDATA MsgType { get; set; }

        public MyCDATA PicUrl { get; set; }

        public MyCDATA MediaId { get; set; }

        public string MsgId { get; set; }
    }
}
