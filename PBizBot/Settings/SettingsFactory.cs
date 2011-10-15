using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Spring.Objects.Factory;

using System.IO;
using log4net;

namespace PBizBot.Settings
{
    public class SettingsFactory : IInitializingObject
    {
        private static readonly ILog LOG = LogManager.GetLogger(typeof(SettingsFactory));

        private String m_settingsPath = "settings.xml";

        private XmlSerializer m_xmlSerializer;
        private Settings m_settings;

        public Settings Default
        {
            get { return this.m_settings; }
        }

        public String SettingsPath
        {
            get { return this.m_settingsPath; }
            set { this.m_settingsPath = value; }
        }

        public void SaveSettings()
        {
            StreamWriter writer = new StreamWriter(m_settingsPath, false);
            m_xmlSerializer.Serialize(writer, m_settings);
            writer.Close();
            LOG.Info("Plik konfiguracji głównych " + m_settingsPath + " został nadpisany.");
        }

        public void ForceReLoadingSettings()
        {
            StreamReader reader = StreamReader.Null;
            try
            {
                reader = new StreamReader(m_settingsPath);
                this.m_settings = (Settings)m_xmlSerializer.Deserialize(reader);
                LOG.Info("Konfiguracja została pomyślnie wczytana z pliku " + m_settingsPath);
            }
            catch (FileNotFoundException ex)
            {
                LOG.Warn("Brak pliku " + m_settingsPath + "!");
                LOG.Warn("Konfiguracja główna aplikacji została zainicjowana i jest pusta");
                LOG.Debug(ex.StackTrace);
            }
            finally
            {
                reader.Close();
            }
        }

        public void AfterPropertiesSet()
        {
            this.m_settings = new Settings();
            this.m_xmlSerializer = new XmlSerializer(m_settings.GetType());
            ForceReLoadingSettings();
        }
    }
}
