using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Exceptions
{
    class LoginException : Exception
    {
        public LoginException() { }

        public LoginException(string message) : base(message) { }
    }
}
