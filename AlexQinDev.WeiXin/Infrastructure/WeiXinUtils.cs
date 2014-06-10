using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using AlexQinDev.WeiXin.Model;
using System.Web;

namespace AlexQinDev.WeiXin.Infrastructure
{
    public class WeiXinUtils
    {
        private static readonly string _getAccessTokenUrl = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";
        private static readonly string _createMenuUrl = "https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}";
        private static readonly string _getMenuUrl = "https://api.weixin.qq.com/cgi-bin/menu/get?access_token={0}";
        private static readonly string _deleteMenuUrl = "https://api.weixin.qq.com/cgi-bin/menu/delete?access_token={0}";

        public static string GetSha1(System.Collections.Generic.List<string> codelist)
        {
            codelist.Sort();
            var combostr = string.Empty;
            for (int i = 0; i < codelist.Count; i++)
            {
                combostr += codelist[i];
            }
            return EncryptToSHA1(combostr);
        }

        public static string EncryptToSHA1(string str)
        {
            System.Security.Cryptography.SHA1CryptoServiceProvider sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] str1 = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] str2 = sha1.ComputeHash(str1);
            sha1.Clear();
            (sha1 as IDisposable).Dispose();
            return Convert.ToBase64String(str2);
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="intput">输入字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string SHA1Encrypt(string intput)
        {
            byte[] StrRes = Encoding.Default.GetBytes(intput);
            System.Security.Cryptography.HashAlgorithm mySHA = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            StrRes = mySHA.ComputeHash(StrRes);
            StringBuilder EnText = new StringBuilder();
            foreach (byte Byte in StrRes)
            {
                EnText.AppendFormat("{0:x2}", Byte);
            }
            return EnText.ToString();
        }

        /// <summary>
        /// 检查签名
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static bool CheckSignature(string signature, string timestamp, string nonce, string token)
        {
            List<string> list = new List<string>();
            list.Add(token);
            list.Add(timestamp);
            list.Add(nonce);
            //排序
            list.Sort();
            //拼串
            string input = string.Empty;
            foreach (var item in list)
            {
                input += item;
            }
            //加密
            string new_signature = SHA1Encrypt(input);
            //验证
            if (new_signature == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DateTime UnixTimeToTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        public static int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }

        public static string SendHttpGetRequest(string url)
        {
            string result = string.Empty;
            WebClient client = new WebClient();
            using (Stream stream = client.OpenRead(url))
            {
                StreamReader sr = new StreamReader(stream, System.Text.Encoding.UTF8);
                result = sr.ReadToEnd();
                sr.Close();
            }
            return result;
        }

        public static string SendHttpPostRequest(string url, string data)
        {
            string result = string.Empty;
            WebClient client = new WebClient();
            result = client.UploadString(url, data);
            return result;
        }

        /// <summary>
        /// 读取请求对象的内容
        /// 只能读一次
        /// </summary>
        /// <param name="request">HttpRequest对象</param>
        /// <returns>string</returns>
        public static string ReadRequest(HttpRequestBase request)
        {
            //int contentLength = this.Request.ContentLength;
            //byte[] buffer = new byte[contentLength];
            //this.Request.InputStream.Read(buffer, 0, contentLength);
            //string xml = System.Text.UTF8Encoding.UTF8.GetString(buffer);
            string reqStr = string.Empty;
            using (Stream s = request.InputStream)
            {
                using (StreamReader reader = new StreamReader(s, Encoding.UTF8))
                {
                    reqStr = reader.ReadToEnd();
                }
            }

            return reqStr;
        }

        #region WinXin Interaction

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <returns></returns>
        public static string GetAccessToken(string appId, string appSecret)
        {
            WebClient client = new WebClient();
            string getAccessTokenUrl = string.Format(_getAccessTokenUrl, appId, appSecret);
            string jsonData = SendHttpGetRequest(getAccessTokenUrl);

            return JsonConvert.DeserializeObject<AccessToken>(jsonData).access_token;
        }

        public static string CreateMenu(MenuButton menuButton, string appId, string appSecret)
        {
            string result = string.Empty;
            string data = JsonConvert.SerializeObject(menuButton);
            string accessToken = GetAccessToken(appId, appSecret);
            result = SendHttpPostRequest(string.Format(_createMenuUrl, accessToken), data);

            return result;
        }

        public static string GetMenu(string appId, string appSecret)
        {
            string result = string.Empty;
            string accessToken = GetAccessToken(appId, appSecret);
            result = SendHttpGetRequest(string.Format(_getMenuUrl, accessToken));

            return result;
        }

        public static string DeleteMenu(string appId, string appSecret)
        {
            string result = string.Empty;
            string accessToken = GetAccessToken(appId, appSecret);
            result = SendHttpGetRequest(string.Format(_deleteMenuUrl, accessToken));

            return result;
        }

        public static string GetSendTextMessage(MyCDATA fromUserName, MyCDATA toUserName, string content)
        {
            string result = string.Empty;
            SendTextMessage send = new SendTextMessage();
            send.FromUserName = fromUserName;
            send.ToUserName = toUserName;
            send.CreateTime = ConvertDateTimeInt(DateTime.Now).ToString();
            send.MsgType = MsgType.Text.ToString().ToLower();
            send.Content = content;
            result = XmlHelper.XmlSerialize(send, System.Text.Encoding.UTF8);

            return result;
        }

        public static string GetSendImageTextMessage(MyCDATA fromUserName, MyCDATA toUserName, Articles articles)
        {
            string result = string.Empty;
            SendImageTextMessage sendImageTextMessage = new SendImageTextMessage();
            sendImageTextMessage.FromUserName = fromUserName;
            sendImageTextMessage.ToUserName = toUserName;
            sendImageTextMessage.CreateTime = ConvertDateTimeInt(DateTime.Now).ToString();
            sendImageTextMessage.MsgType = MsgType.News.ToString().ToLower();
            sendImageTextMessage.ArticleCount = articles.Item.Count;
            sendImageTextMessage.Articles = articles;
            result = XmlHelper.XmlSerialize(sendImageTextMessage, System.Text.Encoding.UTF8);

            return result;
        }

        public static void WriteText(string content)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\log.txt";
            using (StreamWriter sw = System.IO.File.CreateText(path))
            {
                sw.Write(string.Format("{0}--{1}", content, DateTime.Now.ToString()));
                sw.Close();
            }
        }

        #endregion
    }
}
