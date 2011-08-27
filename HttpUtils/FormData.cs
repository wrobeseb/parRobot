using System;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;
using System.Text;

namespace HttpUtils
{
    public class FormData
    {
        private NameValueCollection values;

        public void addValue(String key, String value)
        {
            if (values == null) values = new NameValueCollection();
            values.Add(key, value);
        }

        public void addValues(NameValueCollection values)
        {
            if (values == null) values = new NameValueCollection();
            this.values.Add(values);
        }

        public byte[] getBytes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (String key in values)
            {
                stringBuilder.Append(key).Append("=").Append(values.Get(key)).Append("&");
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);

            return Encoding.ASCII.GetBytes(stringBuilder.ToString());
        }
    }
}
