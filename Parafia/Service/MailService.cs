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

        public static bool sendMail(Attributes.Attributes attribute, Units units, DateTime nextLogin, int attackResult, bool overflowFlag)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("<html><head></head><body style=\"font: 12px/1.2 Arial, Helvetica, Tahoma, sans-serif;\"><div style=\"width: 100%; height: 100%; background: #ffffff;\" >");

            if (overflowFlag)
            {
                builder.Append("<ul style=\"line-height: 1.2em;list-style: none; margin-bottom: 10px\">");
                builder.Append("	<li><strong>Przepełnienie!!!!!!!!!:</strong></li>");
                builder.Append("</ul>");
            }

            builder.Append("<div style=\"padding: 0 0 0 10px; width: 700px;\">");
            builder.Append("<h2 style=\"color: #4a2c5c;font: normal 20px/1em 'Lucida Sans Unicode', Arial, Helvetica, Tahoma, sans-serif;padding: 0;border-bottom: 1px solid #e7e7e7;\">Staty</h2>");
            builder.Append("<table><tr><td style=\"vertical-align: top; width: 650px;\">");
            builder.Append(attribute.ToHtml());
            builder.Append("</td><td style=\"vertical-align: top; width: 350px;\">");
            builder.Append("<div style=\"line-height: 1.2em; margin-bottom: 10px\">");
            builder.Append("	<div><strong>Nastepne logowanie:</strong> ").Append(nextLogin.ToString("yyyy-MM-dd HH:mm:ss")).Append("</div>");
            builder.Append("	<div><strong>Rezultat po atakach:</strong> ").Append(attackResult).Append("</div>");
            builder.Append("	<div><strong>Poczta:</strong> ").Append(attribute.Mail).Append("</div>");
            builder.Append("</div>");
            builder.Append("</td></tr></table></div>");
            builder.Append(units.ToHtml());
            builder.Append("</div></body></html>");

            return sendMail(builder.ToString());
        }
    }
}
