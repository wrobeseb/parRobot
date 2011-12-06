using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Service
{
    using Core.Session;

    public interface IHttpService
    {
        Boolean Login(Session session);
        Boolean Logout(Session session);

        void UpdateAttributes(Session session);
    }
}
