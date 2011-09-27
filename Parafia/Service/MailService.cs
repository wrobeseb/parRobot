using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using Parafia.Properties;

namespace Parafia.Service
{
    using Model;
    using Units;

    public class MailService
    {
        private static SmtpClient smtpClient;

        public static bool sendMail(String body)
        {
            Object obj  = Settings.Default["properties"];
            if (obj != null) {
                ApplicationConfig config = (ApplicationConfig) obj;
                if (config != null && !String.IsNullOrEmpty(config.SmtpHost)) {

                    //ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                    
                    MailMessage mail = new MailMessage();
                    if (smtpClient == null)
                    {
                        smtpClient = new SmtpClient(config.SmtpHost);
                        smtpClient.Port = config.SmtpPort;
                        smtpClient.Credentials = new System.Net.NetworkCredential(config.SmtpAccount, config.SmtpAccountPasswd);
                        smtpClient.EnableSsl = config.SmtpEnableSSL;
                    }

                    mail.From = new MailAddress("sezam_cm@telekomunikacja.pl");
                    mail.To.Add(config.SmtpTo);
                    mail.Subject = config.SmtpSubject;
                    mail.IsBodyHtml = true;
                    mail.BodyEncoding = Encoding.GetEncoding("ISO-8859-2");
                    mail.Body = body;

                    smtpClient.Send(mail);
                    return true;
                }
            }
            return false;
        }

        public static bool sendMail(Attributes.Attributes attribute, Units units)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("<html><head></head><body style=\"font: 12px/1.2 Arial, Helvetica, Tahoma, sans-serif;\"><div style=\"width: 100%; height: 100%; background: #ffffff;\" >");
            builder.Append(attribute.ToHtml());
            builder.Append("\n");
            builder.Append(units.ToHtml());
            builder.Append("</div></body></html>");

            return sendMail(builder.ToString());
        }
    }
}
