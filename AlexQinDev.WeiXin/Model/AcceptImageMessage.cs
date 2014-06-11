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
    public class AcceptImageMessage : AcceptMessage
    {
        public MyCDATA PicUrl { get; set; }

        public MyCDATA MediaId { get; set; }

        public string MsgId { get; set; }
    }
}
