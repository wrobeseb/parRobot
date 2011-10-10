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
            HttpWebRequest request = HttpRequest.SendPost(url, cookieContainer, formData, headers);
            //request.CookieContainer = cookieContainer;
            return (HttpWebResponse)request.GetResponse();
        }

        public HttpWebResponse HttpPost(String url, FormData formData)
        {
            HttpWebRequest request = HttpRequest.SendPost(url, cookieContainer, formData);
            return (HttpWebResponse)request.GetResponse();
        }

        public HttpWebResponse HttpPost(String url, FormData formData, int timeout)
        {
            HttpWebRequest request = HttpRequest.SendPost(url, cookieContainer, formData, timeout);
            return (HttpWebResponse)request.GetResponse();
        }

        public HttpWebResponse HttpPostWithoutRedirection(String url, FormData formData)
        {
            HttpWebRequest request = HttpRequest.SendPostWithoutRedirection(url, cookieContainer, formData);
            return (HttpWebResponse)request.GetResponse();
        }

        public String SendHttpPostAndReturnResponseContent(String url, FormData formData)
        {
            return HtmlUtils.GetContentForResponse(HttpPost(url, formData));
        }

        public String SendHttpPostAndReturnResponseContent(String url, FormData formData, int timeout)
        {
            return HtmlUtils.GetContentForResponse(HttpPost(url, formData, timeout));
        }

        public String SendHttpPostAndReturnResponseContent(String url, FormData formData, NameValueCollection headers)
        {
            return HtmlUtils.GetContentForResponse(HttpPost(url, formData, headers));
        }

        public HttpWebResponse HttpGet(String url)
        {
            HttpWebRequest request = HttpRequest.SendGet(url);
            request.CookieContainer = cookieContainer;
            request.Timeout = 20000;
            return (HttpWebResponse)request.GetResponse();
        }

        public HttpWebResponse HttpGet(String url, int timeout)
        {
            HttpWebRequest request = HttpRequest.SendGet(url);
            request.CookieContainer = cookieContainer;
            request.Timeout = timeout;
            return (HttpWebResponse)request.GetResponse();
        }

        public String SendHttpGetAndReturnResponseContent(String url)
        {
            return HtmlUtils.GetContentForResponse(HttpGet(url));
        }

        public String SendHttpGetAndReturnResponseContent(String url, int timeout)
        {
            return HtmlUtils.GetContentForResponse(HttpGet(url, timeout));
        }

        
    }
}
