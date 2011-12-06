using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Objects.Factory;
using System.Xml.Serialization;
using System.IO;

namespace ParafiaPRO.Core
{
    using Properties;
    using log4net; 

    public class Settings : IInitializingObject, IDisposable
    {
        private static ILog log = LogManager.GetLogger(typeof(Settings));

        private XmlSerializer mSerializer;
        private Properties.Properties mProperties;

        public Properties.Properties Default
        {
            get { return this.mProperties; }
        }

        public void SaveProperties(Properties.Properties properties)
        {
            this.mProperties = properties;
            Save(properties);
        }

        public Properties.Properties LoadProperties()
        {
            this.mProperties = Load();
            return this.mProperties;
        }

        public void AfterPropertiesSet()
        {
            this.mProperties = Load();
        }

        public void Dispose()
        {
            Save(this.mProperties);
        }

        private void Save(Properties.Properties properties)
        {
            log.Info("Rozpoczynam proces zapisywania parametrów do pliku...");
            TextWriter writer = new StreamWriter(Properties.Properties.DEFAULT_SETTINGS_FILE_LOCATION);
            mSerializer.Serialize(writer, properties);
            writer.Close();
            log.Info("Parametry zostały zapisane...");
        }

        private Properties.Properties Load()
        {
            log.Info("Rozpoczynam proces pobrania parametrów z pliku...");
            Properties.Properties properties = new Properties.Properties();
            mSerializer = new XmlSerializer(typeof(Properties.Properties));
            try
            {
                TextReader reader = new StreamReader(Properties.Properties.DEFAULT_SETTINGS_FILE_LOCATION);
                properties = (Properties.Properties)mSerializer.Deserialize(reader);
                reader.Close();
                log.Info("Parametry zostały pobrane...");
                log.Info(properties.LogFormat);
            }
            catch (FileNotFoundException fileNotFoundExc) 
            {
                log.Error("Brak pliku z parametrami.", fileNotFoundExc);
            }

            return properties;
        }
    }
}
