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
    public class AcceptTextMessage : AcceptMessage 
    {
        public MyCDATA Content { get; set; }

        public long MsgId { get; set; }
    }
}
