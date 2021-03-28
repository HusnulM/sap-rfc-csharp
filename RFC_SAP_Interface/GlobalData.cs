using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector;
using System.Data;

namespace RFC_SAP_Interface
{
    public class GlobalData
    {
        public static RfcRepository rfcRepository;
        public static RfcDestination rfcDestination;

        public static DataTable generateDataTable(DataTable dt, IRfcTable rfcTable)
        {
            foreach (IRfcStructure row in rfcTable)
            {
                DataRow newRow = dt.NewRow();
                for (int element = 0; element < rfcTable.ElementCount; element++)
                {
                    RfcElementMetadata metadata = rfcTable.GetElementMetadata(element);
                    var nrow = newRow[element];
                    var rrow = row.GetString(metadata.Name);
                    newRow[element] = row.GetString(metadata.Name);

                }
                dt.Rows.Add(newRow);
            }

            return dt;

        }
    }
}
