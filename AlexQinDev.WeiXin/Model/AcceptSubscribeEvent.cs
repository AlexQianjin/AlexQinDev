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
    public class AcceptSubscribeEvent : AcceptMessage
    {
        public MyCDATA Event { get; set; }
    }
}
