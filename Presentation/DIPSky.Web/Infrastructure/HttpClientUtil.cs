using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Data;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Web.Mail;
namespace DIPSky.Web.Infrastructure
{
    public class HttpClientUtil
    {
        #region HttpWebRequestPost;
        /// <summary>
        /// HttpWebRequestPost;
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <param name="tocken"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static string HttpWebRequestPost(string Appid, string apiUrl, string token, string body)
        {
            try
            {

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiUrl);
                request.Method = "POST";
                request.ContentType = "application/json";
                if (false == string.IsNullOrEmpty(Appid))
                {
                    request.Headers.Add("x-accela-appid:" + Appid + "");
                }
                if (false == string.IsNullOrEmpty(token))
                    request.Headers.Add("Authorization", token);

                ServiceCertificate();
                using (StreamWriter dataStream = new StreamWriter(request.GetRequestStream()))
                {
                    dataStream.Write(body);
                    dataStream.Close();
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader dataStream = new StreamReader(response.GetResponseStream()))
                {
                    var result = dataStream.ReadToEnd();
                    dataStream.Close();

                    return result;
                }
            }
            catch (Exception ex)
            {
                string err = "";
                if (ex.InnerException != null)
                {
                    err = ex.InnerException.Message;
                }
                else
                {
                    err = ex.Message;
                }
                return err;
            }
        }
        #endregion


        #region HttpWebRequestPostFile;
        /// <summary>
        /// HttpWebRequestPostFile;
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <param name="tocken"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static string HttpWebRequestUploadFile(string url, string Appid, string token, int timeOut, string fileKeyName, string filename, Stream stream, NameValueCollection stringDictBody)
        {
            string responseContent;
            var memStream = new MemoryStream();
            var webRequest = (HttpWebRequest)WebRequest.Create(url);

            if (false == string.IsNullOrEmpty(Appid))
            {
                webRequest.Headers.Add("x-accela-appid:" + Appid + "");
            }
            if (false == string.IsNullOrEmpty(token))
                webRequest.Headers.Add("Authorization", token);

            // 边界符
            var boundary = "---------------" + DateTime.Now.Ticks.ToString("x");
            // 边界符
            var beginBoundary = Encoding.ASCII.GetBytes("--" + boundary + "\r\n");
            var fileStream = stream; //new FileStream(filePath, FileMode.Open, FileAccess.Read);
            // 最后的结束符
            var endBoundary = Encoding.ASCII.GetBytes("--" + boundary + "--\r\n");

            // 设置属性
            webRequest.Method = "POST";
            webRequest.Timeout = timeOut;
            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;

            // 写入文件
            const string filePartHeader =
                "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n" +
                 "Content-Type: application/octet-stream\r\n\r\n";
            var header = string.Format(filePartHeader, fileKeyName, filename);
            var headerbytes = Encoding.UTF8.GetBytes(header);

            memStream.Write(beginBoundary, 0, beginBoundary.Length);
            memStream.Write(headerbytes, 0, headerbytes.Length);

            var buffer = new byte[1024];
            int bytesRead; // =0

            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                memStream.Write(buffer, 0, bytesRead);
            }

            // 写入字符串的Key
            var stringKeyHeader = "\r\n--" + boundary +
                                   "\r\nContent-Disposition: form-data; name=\"{0}\"" +
                                   "\r\n\r\n{1}\r\n";

            foreach (byte[] formitembytes in from string key in stringDictBody.Keys
                                             select string.Format(stringKeyHeader, key, stringDictBody[key])
                                                 into formitem
                                                 select Encoding.UTF8.GetBytes(formitem))
            {
                memStream.Write(formitembytes, 0, formitembytes.Length);
            }

            // 写入最后的结束边界符
            memStream.Write(endBoundary, 0, endBoundary.Length);

            webRequest.ContentLength = memStream.Length;

            var requestStream = webRequest.GetRequestStream();

            memStream.Position = 0;
            var tempBuffer = new byte[memStream.Length];
            memStream.Read(tempBuffer, 0, tempBuffer.Length);
            memStream.Close();

            requestStream.Write(tempBuffer, 0, tempBuffer.Length);
            requestStream.Close();
            ServiceCertificate();
            var httpWebResponse = (HttpWebResponse)webRequest.GetResponse();

            using (var httpStreamReader = new StreamReader(httpWebResponse.GetResponseStream(),
                                                            Encoding.GetEncoding("utf-8")))
            {
                responseContent = httpStreamReader.ReadToEnd();
            }

            fileStream.Close();
            httpWebResponse.Close();
            webRequest.Abort();

            return responseContent;
        }
        #endregion

        #region HttpWebRequestPost;
        /// <summary>
        /// HttpWebRequestPost;
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <param name="tocken"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static string HttpWebRequestPost(string Appid, string apiUrl, string body)
        {
            return HttpWebRequestPost(Appid, apiUrl, "", body);
        }
        #endregion

        #region SendHttpGet;
        /// <summary>
        /// SendHttpGet
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Appid"></param>
        /// <param name="tocken"></param>
        /// <returns></returns>
        public static string SendHttpGet(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            ServiceCertificate();
            StringBuilder sbResponse = new StringBuilder();
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());

                sbResponse.Append(reader.ReadToEnd());
            }

            string sbResponseValue = sbResponse.ToString();
            return sbResponseValue;
        }

        /// <summary>
        /// ServiceCertificate
        /// </summary>
        private static void ServiceCertificate()
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(VerifyServerCertificate);
        }

        private static bool VerifyServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            //if (sslPolicyErrors == SslPolicyErrors.None) return true;

            //foreach (X509ChainStatus s in chain.ChainStatus)
            //{
            //    // allows expired certificates
            //    if (string.Equals(s.Status.ToString(), "NotTimeValid",
            //        StringComparison.OrdinalIgnoreCase))
            //        return true;
            //}

            return true;
        }

        #endregion


        #region 发邮件;
        /// <summary>
        /// 发邮件;
        /// </summary>
        /// <param name="Subject">主题</param>
        /// <param name="Body">内容</param>
        public static void SendMail(string Subject, string Body, string ToEmal)
        {
            string SendUserName = "missionskytest@126.com";
            string SendPassword = "missionsky";
            string SmtpServer = "smpt.126.com";
            System.Web.Mail.MailMessage email = new System.Web.Mail.MailMessage();
            email.From = SendUserName;

            email.To = "yangsizhuan@126.com;" + ToEmal;
            email.Subject = Subject;//邮件的主题
            email.Body = Body; //邮件的正文内容
            email.BodyFormat = MailFormat.Html;
            email.Priority = MailPriority.High;

            email.Fields.Add(@"http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");   //表示基本验证
            email.Fields.Add(@"http://schemas.microsoft.com/cdo/configuration/sendusername", SendUserName);  //发件人的Email登录用户名
            email.Fields.Add(@"http://schemas.microsoft.com/cdo/configuration/sendpassword", SendPassword);  //发件人的Email登录密码
            SmtpMail.SmtpServer = SmtpServer;//发送邮件服务器地址
            try
            {
                SmtpMail.Send(email);//发送邮件
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region SendHttpGetFile;
        /// <summary>
        /// SendHttpGet
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Appid"></param>
        /// <param name="tocken"></param>
        /// <returns></returns>
        public static byte[] SendHttpDownLoadFile(string url, string Appid, string token, ref string Content_Disposition)
        {
            byte[] retData = null;
            using (WebClient client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                client.Headers.Add("x-accela-appid:" + Appid + "");
                client.Headers.Add("Authorization:" + token + "");
                ServiceCertificate();
                retData = client.DownloadData(url);
                Content_Disposition = client.ResponseHeaders["Content-Disposition"];
            }
            return retData;
        }
        #endregion

        #region HttpWebRequestPut
        /// <summary>
        /// HttpWebRequestPut
        /// </summary>
        /// <param name="Appid"></param>
        /// <param name="apiUrl"></param>
        /// <param name="token"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static string HttpWebRequestPut(string Appid, string apiUrl, string token, string dataBody)
        {
            try
            {

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiUrl);
                request.Method = "PUT";
                request.ContentType = "application/json";
                if (false == string.IsNullOrEmpty(token))
                {
                    request.Headers.Add("x-accela-appid:" + Appid + "");
                }
                if (false == string.IsNullOrEmpty(token))
                    request.Headers.Add("Authorization", token);

                ServiceCertificate();
                using (StreamWriter dataStream = new StreamWriter(request.GetRequestStream()))
                {
                    dataStream.Write(dataBody);
                    dataStream.Close();
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader dataStream = new StreamReader(response.GetResponseStream()))
                {
                    var result = dataStream.ReadToEnd();
                    dataStream.Close();

                    return result;
                }
            }
            catch (Exception exc)
            {
                return "{\"error\":\"" + exc.Message + "\"}";
            }
        }

        #endregion

        #region SendHttpDelete
        /// <summary>
        /// SendHttpDelete
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Appid"></param>
        /// <param name="tocken"></param>
        /// <returns></returns>
        public static string SendHttpDelete(string url, string Appid, string token)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Headers.Add("x-accela-appid:" + Appid + "");
            if (false == string.IsNullOrEmpty(token))
                request.Headers.Add("Authorization", token);

            ServiceCertificate();
            StringBuilder sbResponse = new StringBuilder();
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());

                sbResponse.Append(reader.ReadToEnd());
            }

            string sbResponseValue = sbResponse.ToString();
            return sbResponseValue;
        }
        #endregion

        #region json Convert Dictionary;
        /// <summary>  
        /// json Convert Dictionary  
        /// </summary>  
        /// <param name="json">json</param>  
        /// <returns></returns>  
        public static Dictionary<string, object> JsonToDictionary(string json)
        {
            JavaScriptSerializer JSS = new JavaScriptSerializer();


            object obj = JSS.DeserializeObject(json);
            Dictionary<string, object> datajson = (Dictionary<string, object>)obj;

            return datajson;
        }
        #endregion
    }
}
