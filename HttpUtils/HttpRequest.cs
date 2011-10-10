using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Net.Cache;

namespace HttpUtils
{
    public class HttpRequest
    {
        private static WebProxy webProxy;

        public static WebProxy SetWebProxy
        {
            set
            {
                webProxy = value;
            }
        }

        private static void AddDefaultHeaders(HttpWebRequest request)
        {
            request.Headers.Add("Accept-Charset", "ISO-8859-2,utf-8;q=0.7,*;q=0.7");
            request.Headers.Add("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
            request.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.215 Safari/535.1";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            if (request.Method.Equals("POST"))
                request.ContentType = "application/x-www-form-urlencoded";
        }

        public static HttpWebRequest SendPost(String url, CookieContainer cookieContainer, FormData formData) 
        {
            HttpWebRequest request = DefaultPostHttpRequest(url);
            request.CookieContainer = cookieContainer;
            request.Timeout = 20000;
            WriteFormData(request, formData);
            return request;
        }

        public static HttpWebRequest SendPost(String url, CookieContainer cookieContainer, FormData formData, int timeout)
        {
            HttpWebRequest request = DefaultPostHttpRequest(url);
            request.CookieContainer = cookieContainer;
            request.Timeout = timeout;
            WriteFormData(request, formData);
            return request;
        }

        public static HttpWebRequest SendPostWithoutRedirection(String url, CookieContainer cookieContainer, FormData formData)
        {
            HttpWebRequest request = DefaultPostHttpRequest(url);
            request.AllowAutoRedirect = false;
            request.CookieContainer = cookieContainer;
            WriteFormData(request, formData);
            return request;
        }

        public static HttpWebRequest SendPost(String url, CookieContainer cookieContainer, FormData formData, NameValueCollection headers)
        {
            HttpWebRequest request = DefaultPostHttpRequest(url);
            request.Headers.Add(headers);
            request.CookieContainer = cookieContainer;
            /*RequestCachePolicy policy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            request.CachePolicy = policy;
            request.KeepAlive = true;
            request.Host = "trade.plus500.com";
            request.Referer = "https://trade.plus500.com/Login?forceDisplay=True&IsRealMode=False";
           */
            WriteFormData(request, formData);
            return request;
        }

        public static HttpWebRequest SendGet(String url)
        {
            return DefaultGetHttpRequest(url);
        }

        private static void WriteFormData(HttpWebRequest request, FormData formData)
        {
            byte[] buffer = formData.getBytes();
            request.ContentLength = buffer.Length;

            Stream postData = request.GetRequestStream();
            postData.Write(buffer, 0, buffer.Length);
            postData.Close();
        }

        private static HttpWebRequest DefaultPostHttpRequest(String url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Proxy = webProxy;
            request.Method = "POST";
            AddDefaultHeaders(request);
            return request;
        }

        private static HttpWebRequest DefaultGetHttpRequest(String url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Proxy = webProxy;
            request.Method = "GET";
            AddDefaultHeaders(request);
            return request;
        }
    }
}
