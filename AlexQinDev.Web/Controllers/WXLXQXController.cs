using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

using Newtonsoft.Json;

using AlexQinDev.WeiXin.Infrastructure;
using AlexQinDev.WeiXin.Model;
using AlexQinDev.WeiXin.Service.Interfaces;
using AlexQinDev.WeiXin.Service;

namespace AlexQinDev.Web.Controllers
{
    public class WXLXQXController : Controller
    {
        // 115.29.47.210

        //
        // GET: /ResponseMsg/
        public ActionResult Index()
        {
            string content = string.Empty;
            ContentResult result = new ContentResult();

            string v = "qianjinq";
            string r1 = WeiXinUtils.EncryptToSHA1(v);
            string r2 = WeiXinUtils.SHA1Encrypt(v);

            //Articles articles = new Articles();
            //articles.Item.Add(new Article { Title = "xxx", Description = "xxx", PicUrl = "xxx", Url = "xxx" });
            //articles.Item.Add(new Article { Title = "xxx", Description = "xxx", PicUrl = "xxx", Url = "xxx" });
            //SendImageTextMessage sendImageTextMessage = new SendImageTextMessage();
            //sendImageTextMessage.ToUserName = new MyCDATA("aaa");
            //sendImageTextMessage.FromUserName = new MyCDATA("aaa");
            //sendImageTextMessage.CreateTime = "CreateTime";
            //sendImageTextMessage.MsgType = new MyCDATA("aaa");
            //sendImageTextMessage.ArticleCount = 9999;
            //sendImageTextMessage.Articles = articles;

            //content = XmlHelper.XmlSerialize(sendImageTextMessage, System.Text.Encoding.UTF8);

            //List<string> list = MovieWord.GetInstance().GetMovieWords();

            //Random r = new Random();
            //int randomIndex = r.Next(list.Count - 1);

            //content = MovieWord.GetInstance().GetRandomMovieWord();
            MenuButton menuButton = new MenuButton();

            SubButton sub_Button1 = new SubButton();
            sub_Button1.Name = "服务中心";
            ViewButton subViewButton11 = new ViewButton { Name = "游船APP", Url = "http://www.hxy365.com/" };
            ViewButton subViewButton12 = new ViewButton { Name = "线路导航", Url = "http://www.hxy365.com/" };
            ViewButton subViewButton13 = new ViewButton { Name = "我要购票", Url = "http://www.hxy365.com/" };
            ViewButton subViewButton14 = new ViewButton { Name = "我的订单", Url = "http://www.hxy365.com/" };
            ViewButton subViewButton15 = new ViewButton { Name = "联系我们", Url = "http://www.hxy365.com/" };
            sub_Button1.Sub_Button.Add(subViewButton11);
            sub_Button1.Sub_Button.Add(subViewButton12);
            sub_Button1.Sub_Button.Add(subViewButton13);
            sub_Button1.Sub_Button.Add(subViewButton14);
            sub_Button1.Sub_Button.Add(subViewButton15);

            ViewButton viewButton2 = new ViewButton { Name = "公司简介", Url = "http://www.hxy365.com/" };

            SubButton sub_Button3 = new SubButton();
            sub_Button3.Name = "菜单";
            ViewButton subViewButton31 = new ViewButton { Name = "新闻活动", Url = "http://www.hxy365.com/" };
            ViewButton subViewButton32 = new ViewButton { Name = "视频", Url = "http://www.hxy365.com/" };
            ViewButton subViewButton33 = new ViewButton { Name = "我要购票", Url = "http://www.hxy365.com/" };
            sub_Button3.Sub_Button.Add(subViewButton31);
            sub_Button3.Sub_Button.Add(subViewButton32);
            sub_Button3.Sub_Button.Add(subViewButton33);

            menuButton.Button.Add(sub_Button1);
            menuButton.Button.Add(viewButton2);
            menuButton.Button.Add(sub_Button3);

            content = JsonConvert.SerializeObject(menuButton);

            result.Content = content;

            return result;
        }

        public JsonResult CreateMenu()
        {

            return this.Json(new { Code = 1 }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [ActionName("ResponseMsg")]
        public ContentResult ResponseMsgGet(string signature, string timestamp, string nonce, string echostr)
        {
            string content = string.Empty;
            if (WeiXinUtils.CheckSignature(signature, timestamp, nonce, echostr))
            {
                content = echostr;
            }

            ContentResult result = new ContentResult();
            result.Content = content;

            return result;
        }

        [HttpPost]
        [ActionName("ResponseMsg")]
        public ContentResult ResponseMsgPost()
        {
            string content = string.Empty;
            //content = Valid();

            //int contentLength = this.Request.ContentLength;
            //byte[] buffer = new byte[contentLength];
            //this.Request.InputStream.Read(buffer, 0, contentLength);
            //string xml = System.Text.UTF8Encoding.UTF8.GetString(buffer);

            string xml = WeiXinUtils.ReadRequest(this.Request);

            //XElement x = XElement.Parse(xml);
            //string type = x.Element("MsgType").Value;
            //switch (type)
            //{
            //    case "text":
            //        content = ResponseText(xml);
            //        break;
            //    case "event":
            //        content = ResponseEvent(xml);
            //        break;
            //    default:
            //        break;
            //}

            IResponse response = ResponseFactory.Create(xml);
            content = response.GetResponse(xml);

            ContentResult result = new ContentResult();
            result.Content = content;

            return result;
        }

        #region Private Methods

        private string ResponseText(string xml)
        {
            string result = string.Empty;
            AcceptTextMessage accept = XmlHelper.XmlDeserialize<AcceptTextMessage>(xml, System.Text.Encoding.UTF8);
            if (accept.Content.ToString().Trim().Contains("美女"))
            {
                Articles articles = new Articles();
                articles.Item.Add(new Article { Title = "小思妹", Description = "女神小思妹", PicUrl = "http://d.pcs.baidu.com/thumbnail/257482481319ad2b04985c8312102721?fid=3204499409-250528-1696172053&time=1389258327&rt=pr&sign=FDTAER-DCb740ccc5511e5e8fedcff06b081203-omPNoA4KS6gX8I3xGyaVPyyGdo8%3D&expires=8h&prisign=RK9dhfZlTqV5TuwkO5ihMQzlM241kT2YfffnCZFTaEPwOxHv/XxtwRXLxDSXMBba1Ms9seOiqT9/QffwI8K2Baw0mmLABRQNl51b/oS8+InqoadADmwcyikKawH2SpzFmVrGREiaH1zZ09BZiFo3CF7dwGcK/xIzj9971pKao/QALkDxW+JJC9zJS3FHk0o7q45NqZXuYZl9ILH8IdNHtKrjHQBSR0Q9&r=682484659&size=c850_u580&quality=100", Url = "http://115.29.47.210/" });

                result = WeiXinUtils.GetSendImageTextMessage(accept.ToUserName, accept.FromUserName, articles);
            }
            else if (accept.Content.ToString().Trim().Contains("台词"))
            {
                string content = MovieWord.GetInstance().GetRandomMovieWord();
                result = WeiXinUtils.GetSendTextMessage(accept.ToUserName, accept.FromUserName, content);
            }
            else
            {
                string content = "试试发送 美女 或者 台词，有惊喜~";
                result = WeiXinUtils.GetSendTextMessage(accept.ToUserName, accept.FromUserName, content);
            }

            return result;
        }

        private string ResponseEvent(string xml)
        {
            string result = string.Empty;
            XElement x = XElement.Parse(xml);
            string eventType = x.Element("Event").Value;
            switch (eventType)
            {
                case "subscribe":
                    AcceptSubscribeEvent accept = XmlHelper.XmlDeserialize<AcceptSubscribeEvent>(xml, System.Text.Encoding.UTF8);
                    string content = "你好！欢迎关注鲁巷骑行,单车带来更多快乐！";
                    result = WeiXinUtils.GetSendTextMessage(accept.ToUserName, accept.FromUserName, content);
                    break;
                default:
                    break;
            }

            return result;
        }

        private string Valid()
        {
            var echostr = this.Request["echoStr"].ToString();
            string result = string.Empty;
            if (CheckSignature() && !string.IsNullOrEmpty(echostr))
            {
                result = echostr;
            }

            return result;
        }

        private bool CheckSignature()
        {
            var signature = this.Request["signature"].ToString();
            var timestamp = this.Request["timestamp"].ToString();
            var nonce = this.Request["nonce"].ToString();
            var token = "luxiangbike";
            string[] ArrTmp = { token, timestamp, nonce };
            Array.Sort(ArrTmp);     //字典排序
            string tmpStr = string.Join("", ArrTmp);
            tmpStr = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");
            tmpStr = tmpStr.ToLower();
            if (tmpStr == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetSha1(System.Collections.Generic.List<string> codelist)
        {
            codelist.Sort();
            var combostr = string.Empty;
            for (int i = 0; i < codelist.Count; i++)
            {
                combostr += codelist[i];
            }
            return EncryptToSHA1(combostr);
        }

        private string EncryptToSHA1(string str)
        {
            System.Security.Cryptography.SHA1CryptoServiceProvider sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] str1 = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] str2 = sha1.ComputeHash(str1);
            sha1.Clear();
            (sha1 as IDisposable).Dispose();
            return Convert.ToBase64String(str2);
        }

        private DateTime UnixTimeToTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        private int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }

        #endregion
    }
}