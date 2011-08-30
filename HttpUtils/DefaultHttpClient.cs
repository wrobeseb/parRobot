using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace HttpUtils
{
    public class DefaultHttpClient : HttpClient
    {
        private CookieContainer cookieContainer;

        public WebProxy SetWebProxy 
        {
            set 
            {
                HttpRequest.SetWebProxy = value;
            }
        }

        public DefaultHttpClient()
        {
            cookieContainer = new CookieContainer();
        }

        public void AddCookie(Cookie cookie)
        {
            cookieContainer.Add(cookie);
        }

        public CookieContainer CookieContainer
        {
            get { return this.cookieContainer; }
            set { this.cookieContainer = value; }
        }

        public HttpWebResponse HttpPost(String url, FormData formData, NameValueCollection headers)
        {
            HttpWebRequest request = HttpRequest.SendPost(url, formData, headers);
            request.CookieContainer = cookieContainer;
            return (HttpWebResponse)request.GetResponse();
        }

        public HttpWebResponse HttpPost(String url, FormData formData)
        {
            HttpWebRequest request = HttpRequest.SendPost(url, formData);
            request.CookieContainer = cookieContainer;
            return (HttpWebResponse)request.GetResponse();
        }

        public String SendHttpPostAndReturnResponseContent(String url, FormData formData)
        {
            return HtmlUtils.GetContentForResponse(HttpPost(url, formData));
        }

        public String SendHttpPostAndReturnResponseContent(String url, FormData formData, NameValueCollection headers)
        {
            return HtmlUtils.GetContentForResponse(HttpPost(url, formData, headers));
        }

        public HttpWebResponse HttpGet(String url)
        {
            HttpWebRequest request = HttpRequest.SendGet(url);
            request.CookieContainer = cookieContainer;
            return (HttpWebResponse)request.GetResponse();
        }

        public String SendHttpGetAndReturnResponseContent(String url)
        {
            return HtmlUtils.GetContentForResponse(HttpGet(url));
        }

        
    }
}
