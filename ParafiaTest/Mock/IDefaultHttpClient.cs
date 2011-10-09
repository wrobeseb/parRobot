using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

using System.Net;
using System.IO;

using HttpUtils;

namespace ParafiaTest.Mock
{
    public interface IDefaultHttpClient
    {
        HttpWebResponse HttpPost(String url, FormData formData, NameValueCollection headers);

        HttpWebResponse HttpPost(String url, FormData formData);

        HttpWebResponse HttpPostWithoutRedirection(String url, FormData formData);

        String SendHttpPostAndReturnResponseContent(String url, FormData formData);

        String SendHttpPostAndReturnResponseContent(String url, FormData formData, NameValueCollection headers);

        HttpWebResponse HttpGet(String url);

        HttpWebResponse HttpGet(String url, int timeout);

        String SendHttpGetAndReturnResponseContent(String url);

        String SendHttpGetAndReturnResponseContent(String url, int timeout);
    }
}
