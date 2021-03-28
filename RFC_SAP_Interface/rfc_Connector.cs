using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector;

namespace RFC_SAP_Interface
{
    public class rfc_Connector : IDestinationConfiguration
    {
        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;

        public bool ChangeEventsSupported()
        {
            return false;
        }

        public RfcConfigParameters GetParameters(string destinationName)
        {
            if ("SE37".Equals(destinationName))
            {
                

                RfcConfigParameters parms = new RfcConfigParameters();
                parms.Add(RfcConfigParameters.AppServerHost, "");
                parms.Add(RfcConfigParameters.SystemNumber, "10");
                parms.Add(RfcConfigParameters.SystemID, "S4I");
                parms.Add(RfcConfigParameters.User, "");
                parms.Add(RfcConfigParameters.Password, "");
                parms.Add(RfcConfigParameters.Client, "");
                parms.Add(RfcConfigParameters.SAPRouter, "");
                parms.Add(RfcConfigParameters.Language, "EN");
                parms.Add(RfcConfigParameters.Name, "SE37");
                parms.Add(RfcConfigParameters.ConnectionIdleTimeout, "600");
                parms.Add(RfcConfigParameters.PoolSize, "10");

                return parms;
            }
            else
            {
                return null;
            }
        }
    }
}
