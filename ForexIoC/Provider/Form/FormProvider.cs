using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForexIoC.Provider.Form
{
    using ForexIoC.View;

    public class FormProvider
    {
        private MainForm m_mainForm;
        private ConfigurationForm m_configurationForm;

        public MainForm MainForm
        {
            set { m_mainForm = value; }
        }

        public ConfigurationForm ConfigurationForm
        {
            set { m_configurationForm = value; }
        }
    }
}
