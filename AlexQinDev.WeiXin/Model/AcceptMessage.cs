using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexQinDev.WeiXin.Model
{
    [Serializable]
    public class AcceptMessage
    {
        public MyCDATA ToUserName { get; set; }

        public MyCDATA FromUserName { get; set; }

        public string CreateTime { get; set; }

        public MyCDATA MsgType { get; set; }
    }
}
