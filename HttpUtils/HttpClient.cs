using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Net;

namespace HttpUtils
{
    public interface HttpClient
    {
        HttpWebResponse HttpPost(String url, FormData formData, NameValueCollection headers);
        HttpWebResponse HttpPost(String url, FormData formData);
        HttpWebResponse HttpGet(String url);
    }
}
