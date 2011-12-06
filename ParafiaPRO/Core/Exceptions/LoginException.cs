using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Core.Exceptions
{
    class LoginException : Exception
    {
        public LoginException() { }

        public LoginException(string message) : base(message) { }
    }
}
