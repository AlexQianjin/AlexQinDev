using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace AlexQinDev.Web.Controllers
{
    public class UploadApiController : ApiController
    {
        [HttpPost]
        public string Upload()
        {
            if (Request.Content.IsMimeMultipartContent())
            {
                //文件保存目录路径 
                string SaveTempPath = "~/App_Data/";
                string dirTempPath = HttpContext.Current.Server.MapPath(SaveTempPath);
                //Save file
                MultipartFormDataStreamProvider provider = new MultipartFormDataStreamProvider(dirTempPath);

                string filename = "Not set";


                IEnumerable<HttpContent> parts = null;
                Task.Factory
                    .StartNew(() =>
                    {
                        parts = Request.Content.ReadAsMultipartAsync(provider).Result.Contents;
                        filename = "Set Success";

                        Hashtable hash = new Hashtable();
                        hash["error"] = 1;
                        hash["errmsg"] = "上传出错";
                        var file = provider.FileData[0];//provider.FormData 
                        if (provider.FormData.AllKeys.Length > 0)
                        {
                            string id = provider.FormData["id"];
                            string username = provider.FormData["username"];
                        }

                        //string id = provider.FormData.
                        string orfilename = file.Headers.ContentDisposition.FileName.TrimStart('"').TrimEnd('"');
                        FileInfo fileinfo = new FileInfo(file.LocalFileName);
                        //最大文件大小 
                        int maxSize = 10000000;
                        if (fileinfo.Length <= 0)
                        {
                            hash["error"] = 1;
                            hash["errmsg"] = "请选择上传文件。";
                        }
                        else if (fileinfo.Length > maxSize)
                        {
                            hash["error"] = 1;
                            hash["errmsg"] = "上传文件大小超过限制。";
                        }
                        else
                        {
                            string fileExt = orfilename.Substring(orfilename.LastIndexOf('.'));
                            //定义允许上传的文件扩展名 
                            String fileTypes = "gif,jpg,jpeg,png,bmp";
                            if (String.IsNullOrEmpty(fileExt) || Array.IndexOf(fileTypes.Split(','), fileExt.Substring(1).ToLower()) == -1)
                            {
                                hash["error"] = 1;
                                hash["errmsg"] = "上传文件扩展名是不允许的扩展名。";
                            }
                            else
                            {
                                String ymd = DateTime.Now.ToString("yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                                String newFileName = DateTime.Now.ToString("yyyyMMddHHmmss_ffff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                                fileinfo.CopyTo(Path.Combine(dirTempPath, newFileName + fileExt), true);
                                fileinfo.Delete();
                                hash["error"] = 0;
                                hash["errmsg"] = "上传成功";
                            }
                        }

                        filename = hash["errmsg"].ToString();
                    },
                    CancellationToken.None,
                    TaskCreationOptions.LongRunning, // guarantees separate thread
                    TaskScheduler.Default)
                    .Wait();

                return filename;
            }
            else
            {
                return "Invalid.";
            }
        }
    }
}