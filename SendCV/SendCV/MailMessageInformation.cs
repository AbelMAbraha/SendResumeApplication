using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendCV
{
    public class MailMessageInformation
    {
        private string _SendersEmail;
        private string _CompanyEmail;
        private string _Occupation;
        private string _CompanyName;
        private string _Body;
        private string _EmailPassword;
        private string _EmailSubject;
        private string _CV;
        public MailMessageInformation(string sendersEmail, string companyEmail, string occupation, string companyName,string emailPassword, string cv, string emailSubject, string body)
        {
            _SendersEmail = sendersEmail;
            _CompanyEmail = companyEmail;
            _CompanyName = companyName;
            _Occupation = occupation;
            _Body = body;
            _EmailPassword = emailPassword;
            _CV = cv;
            _EmailSubject = emailSubject;
            Messages();
        }
        public void Messages()
        {
            var emailMessage = new MailMessage();
            if (_CV == "")
            {
            }
            else
            {
                System.Net.Mail.Attachment attachment = new Attachment(_CV);
                emailMessage.Attachments.Add(attachment);
            }
            emailMessage.To.Add(new MailAddress(_CompanyEmail));
            emailMessage.Subject = _EmailSubject;
            emailMessage.From = new MailAddress(_SendersEmail);
            emailMessage.Body = string.Format(_Body, _Occupation, _CompanyName);
            emailMessage.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                //SENDS AN EMAIL FROM SPECIFIED EMAIL-ACCOUNT (PASSWORD IS NEEDED) 
                var credential = new NetworkCredential
                {
                    UserName = _SendersEmail,
                    Password = _EmailPassword
                };
                smtp.Credentials = credential;
                //WILL USE GMAIL-HOST IF EMAIL-ACCOUNT CONTAINS THE WORD '@GMAIL.'
                if (_SendersEmail.Contains("@gmail."))
                {
                    smtp.Host = "smtp.gmail.com";
                }
                //IF NOT - WILL USE HOTMAIL.COM
                else
                {
                    smtp.Host = "smtp-mail.outlook.com";
                }
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(emailMessage);
            }
        }
    }
}
