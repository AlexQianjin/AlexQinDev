using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AlexQinDev.WeiXin.Model
{
    /// <summary>
    /// 获取用户地理信息
    /// </summary>
    [Serializable]
    [XmlType("xml")]
    public class AcceptLocationEvent : AcceptMessage
    {
        public MyCDATA Event { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Precision { get; set; }
    }
}
