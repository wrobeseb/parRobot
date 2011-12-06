using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Core.Properties
{
    public partial class Properties
    {
        public static String DEFAULT_SETTINGS_FILE_LOCATION = System.Windows.Forms.Application.StartupPath + @"\Parafia.properties";

        private static String DEFAULT_CONNECTION_PROVIDER = "Microsoft.Jet.OLEDB.4.0";
        private static String DEFAULT_DATA_FILE_LOCATION = System.Windows.Forms.Application.StartupPath + @"\Parafia.mdb";
        private static String DEFAULT_CONNECTION_STRING = @"Provider=" + DEFAULT_CONNECTION_PROVIDER + "; data source=" + DEFAULT_DATA_FILE_LOCATION;

        private String mDataFileLocation;
        private String mConnectionProvider;
        private String mConnectionString;

        public String DataFileLocation
        {
            get
            {
                if (String.IsNullOrEmpty(mDataFileLocation))
                    return DEFAULT_DATA_FILE_LOCATION;
                else
                    return this.mDataFileLocation;
            }
            set { this.mDataFileLocation = value; }
        }

        public String ConnectionProvider
        {
            get
            {
                if (String.IsNullOrEmpty(mConnectionProvider))
                    return DEFAULT_CONNECTION_PROVIDER;
                else
                    return this.mConnectionProvider;
            }
            set { this.mConnectionProvider = value; }
        }

        public String ConnectionString
        {
            get
            {
                if (String.IsNullOrEmpty(mConnectionString))
                    return DEFAULT_CONNECTION_STRING;
                else
                    return this.mConnectionString;
            }
            set { this.mConnectionString = value; }
        }

        public String LogFormat
        {
            get
            {
                StringBuilder builder = new StringBuilder();

                builder.Append("Plik bazy danych: ").Append(this.mDataFileLocation).AppendLine();
                builder.Append("ConnectionProvider: ").Append(this.mConnectionProvider).AppendLine();
                builder.Append("ConnectionString: ").Append(this.mConnectionString).AppendLine();
                builder.Append("Proxy Enabled: ").Append(this.mProxyEnabled).AppendLine();
                builder.Append("Proxy: ").Append(this.mProxyHost).Append(":").Append(this.mProxyPort).AppendLine();
                builder.Append("Proxy User: ").Append(this.mProxyUser).AppendLine();
                builder.Append("Proxy User Domain: ").Append(this.mProxyUserDomain).AppendLine();

                return builder.ToString();
            }
        }
    }
}
