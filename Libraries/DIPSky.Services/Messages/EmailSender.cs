using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using DIPSky.Core.Domain.Messages;

namespace DIPSky.Services.Messages
{
    /// <summary>
    /// Email sender
    /// </summary>
    public partial class EmailSender : IEmailSender
    {
        /// <summary>
        /// Sends an email
        /// </summary>
        /// <param name="emailAccount">Email account to use</param>
        /// <param name="subject">Subject</param>
        /// <param name="body">Body</param>
        /// <param name="fromAddress">From address</param>
        /// <param name="fromName">From display name</param>
        /// <param name="toAddress">To address</param>
        /// <param name="toName">To display name</param>
        /// <param name="bcc">BCC addresses list</param>
        /// <param name="cc">CC addresses list</param>
        /// <param name="attachmentFilePath">Attachment file path</param>
        /// <param name="attachmentFileName">Attachment file name. If specified, then this file name will be sent to a recipient. Otherwise, "AttachmentFilePath" name will be used.</param>
        public void SendEmail(EmailAccount emailAccount, string subject, string body,
            string fromAddress, string fromName, string toAddress, string toName,
            IEnumerable<string> bcc = null, IEnumerable<string> cc = null,
            string attachmentFilePath = null, string attachmentFileName = null)
        {
            SendEmail(emailAccount, subject, body, 
                new MailAddress(fromAddress, fromName), new MailAddress(toAddress, toName),
                bcc, cc, attachmentFilePath, attachmentFileName);
        }

        /// <summary>
        /// Sends an email
        /// </summary>
        /// <param name="emailAccount">Email account to use</param>
        /// <param name="subject">Subject</param>
        /// <param name="body">Body</param>
        /// <param name="from">From address</param>
        /// <param name="to">To address</param>
        /// <param name="bcc">BCC addresses list</param>
        /// <param name="cc">CC addresses list</param>
        /// <param name="attachmentFilePath">Attachment file path</param>
        /// <param name="attachmentFileName">Attachment file name. If specified, then this file name will be sent to a recipient. Otherwise, "AttachmentFilePath" name will be used.</param>
        public virtual void SendEmail(EmailAccount emailAccount, string subject, string body,
            MailAddress from, MailAddress to,
            IEnumerable<string> bcc = null, IEnumerable<string> cc = null,
            string attachmentFilePath = null, string attachmentFileName = null)
        {
            var message = new MailMessage();
            message.From = from;
            message.To.Add(to);
            if (bcc != null)
            {
                foreach (var address in bcc.Where(bccValue => !String.IsNullOrWhiteSpace(bccValue)))
                {
                    message.Bcc.Add(address.Trim());
                }
            }
            if (cc != null)
            {
                foreach (var address in cc.Where(ccValue => !String.IsNullOrWhiteSpace(ccValue)))
                {
                    message.CC.Add(address.Trim());
                }
            }
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            string SendUserName = emailAccount.Email; //"missionskytest@126.com";
            string SendPassword = emailAccount.Password;// "missionsky";
            string SmtpServer = emailAccount.Host;
            System.Web.Mail.MailMessage email = new System.Web.Mail.MailMessage();
            email.From = SendUserName;

            email.To = to.Address;
            email.Subject = message.Subject;//邮件的主题
            email.Body = message.Body; //邮件的正文内容
            email.BodyFormat = System.Web.Mail.MailFormat.Html;
            email.Priority = System.Web.Mail.MailPriority.High;
            email.BodyEncoding = System.Text.UTF8Encoding.UTF8;
            email.Fields.Add(@"http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");   //表示基本验证
            email.Fields.Add(@"http://schemas.microsoft.com/cdo/configuration/sendusername", SendUserName);  //发件人的Email登录用户名
            email.Fields.Add(@"http://schemas.microsoft.com/cdo/configuration/sendpassword", SendPassword);  //发件人的Email登录密码
            System.Web.Mail.SmtpMail.SmtpServer = SmtpServer;//发送邮件服务器地址
            try
            {
                System.Web.Mail.SmtpMail.Send(email);//发送邮件
            }
            catch
            {
                return;
            }
            ////create  the file attachment for this e-mail message
            //if (!String.IsNullOrEmpty(attachmentFilePath) &&
            //    File.Exists(attachmentFilePath))
            //{
            //    var attachment = new Attachment(attachmentFilePath);
            //    attachment.ContentDisposition.CreationDate = File.GetCreationTime(attachmentFilePath);
            //    attachment.ContentDisposition.ModificationDate = File.GetLastWriteTime(attachmentFilePath);
            //    attachment.ContentDisposition.ReadDate = File.GetLastAccessTime(attachmentFilePath);
            //    if (!String.IsNullOrEmpty(attachmentFileName))
            //    {
            //        attachment.Name = attachmentFileName;
            //    }
            //    message.Attachments.Add(attachment);
            //}

            //using (var smtpClient = new SmtpClient())
            //{
            //    smtpClient.UseDefaultCredentials = emailAccount.UseDefaultCredentials;
            //    smtpClient.Host = emailAccount.Host;
            //    smtpClient.Port = emailAccount.Port;
            //    smtpClient.EnableSsl = emailAccount.EnableSsl;
            //    if (emailAccount.UseDefaultCredentials)
            //        smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
            //    else
            //        smtpClient.Credentials = new NetworkCredential(emailAccount.Username, emailAccount.Password);
            //    smtpClient.Send(message);
            //}
        }
    }
}
