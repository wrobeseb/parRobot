using System;
using System.Text;
using System.Collections.Specialized;
using System.Linq;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HttpUtilsTest
{
    [TestClass]
    public class FormDataTest
    {
        [TestMethod]
        public void getBytesTest()
        {
            //given

            NameValueCollection values = new NameValueCollection();
            values.Add("TestKey1", "TestValue1");
            values.Add("TestKey2", "TestValue2");

            byte[] expected = Encoding.ASCII.GetBytes("TestKey1=TestValue1&TestKey2=TestValue2");

            //when

            StringBuilder stringBuilder = new StringBuilder();
            foreach (String key in values)
            {
                stringBuilder.Append(key).Append("=").Append(values.Get(key)).Append("&");
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);

            byte[] actual = Encoding.ASCII.GetBytes(stringBuilder.ToString());

            //then

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
