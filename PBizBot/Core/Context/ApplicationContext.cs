using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Spring.Context;
using Spring.Context.Support;

namespace PBizBot.Core.Context
{
    public class ApplicationContext : IApplicationContextAware
    {
        private IApplicationContext m_applicationContext;

        IApplicationContext IApplicationContextAware.ApplicationContext
        {
            set { this.m_applicationContext = value; }
        }

        public T GetComponentFromContext<T>(string componentName)
        {
            return (T)m_applicationContext.GetObject(componentName);
        }
    }
}
