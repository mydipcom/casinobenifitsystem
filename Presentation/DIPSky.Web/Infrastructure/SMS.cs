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
using System.Configuration;
namespace DIPSky.Web.Infrastructure
{
    public class SMS
    {
        #region SendMessage;
        /// <summary>
        /// SendMessage
        /// </summary>
        /// <returns></returns>
        public static bool SendMessage(string Telephone, string Message, string CountryCode, string UserDefineNo)
        {
            try
            {
                StringBuilder sbRequestUrl = new StringBuilder();
                sbRequestUrl.Append("http://able1.able-sms.com:8080/service/smsapi2.asmx/SendMessage");
                sbRequestUrl.Append("?Username=missionsky");
                sbRequestUrl.Append("&Password=123456");
                sbRequestUrl.Append("&Message=" + Message + "");
                sbRequestUrl.Append("&Telephone=" + Telephone + "");
                sbRequestUrl.Append("&CountryCode=" + CountryCode + "");
                sbRequestUrl.Append("&UserDefineNo=" + UserDefineNo + "");
                string IsSend = ConfigurationManager.AppSettings["IsSendSMS"].ToString();
                if (IsSend == "true")
                {
                    string retMessage = HttpClientUtil.SendHttpGet(sbRequestUrl.ToString());
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
