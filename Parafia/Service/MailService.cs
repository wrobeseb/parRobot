using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using Parafia.Properties;

namespace Parafia.Service
{
    public class MailService
    {
        public static bool sendMail(String to, String subject, String body)
        {
            Object obj  = Settings.Default["properties"];
            if (obj != null) {
                ApplicationConfig config = (ApplicationConfig) obj;
                if (config != null && !String.IsNullOrEmpty(config.SmtpHost)) {

                    //ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                    
                    MailMessage mail = new MailMessage();
                    SmtpClient smtpClient = new SmtpClient(config.SmtpHost);

                    mail.From = new MailAddress("sezam_cm@telekomunikacja.pl");
                    mail.To.Add(to);
                    mail.Subject = subject;
                    mail.Body = body;

                    smtpClient.Port = config.SmtpPort;
                    smtpClient.Credentials = new System.Net.NetworkCredential(config.SmtpAccount, config.SmtpAccountPasswd);
                    smtpClient.EnableSsl = config.SmtpEnableSSL;

                    smtpClient.Send(mail);
                    return true;
                }
            }
            return false;
        }
    }
}
