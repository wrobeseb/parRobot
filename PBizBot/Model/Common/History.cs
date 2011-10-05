using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Model.Common
{
    public class History
    {
        private object m_value;
        private DateTime m_sampleDt;

        public History(object value)
        {
            m_value = value;
            m_sampleDt = DateTime.Now;
        }

        public object Value
        {
            get { return this.m_value; }
        }

        public DateTime SampleDate
        {
            get { return this.m_sampleDt; }
        }
    }
}
