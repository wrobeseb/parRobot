using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParafiaTest.Mock;
using NMock2;

namespace ParafiaTest.Test
{
    public abstract class AbstractTest
    {
        public IDefaultHttpClient getDhcHttpGetMock(String url, String returnValue)
        {
            Mockery mocks = new Mockery();
            IDefaultHttpClient dhcMock = mocks.NewMock<IDefaultHttpClient>();
            Expect.Once.On(dhcMock).Method("SendHttpGetAndReturnResponseContent").With(url).Will(Return.Value(returnValue));
            return dhcMock;
        }
    }
}
