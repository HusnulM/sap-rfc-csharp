using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAP.Middleware.Connector;
using System.Threading;

namespace RFC_SAP_Interface
{
    public partial class Form1 : Form
    {
        string message;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("ZFDLKNA1");
            //getDataSAP.SetValue("P_KUNNR", "ALL");

            //try
            //{
            //    getDataSAP.Invoke(GlobalData.rfcDestination);
            //}
            //catch (Exception ex)
            //{
            //message = "SAP ZFDLKNA1 ";
            //  message += ex.Message;
            //}

            //IRfcTable IT_KNA1 = getDataSAP.GetTable("IT_KNA1");
            //DataSet1 dsUniversal = new DataSet1();

            //DataTable dtKNA1 = dsUniversal.Tables["ZKNA1"];

            //dtKNA1 = CreateDataTable(dtKNA1, IT_KNA1);

            //DGV1.DataSource = dtKNA1;

            readdata();
        }

        public void readdata()
        {
            IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("ZFRFC002");
            try
            {
                getDataSAP.Invoke(GlobalData.rfcDestination);
            }
            catch (Exception ex)
            {
                message = "SAP ZFDLKNA1 ";
                message += ex.Message;
            }

            IRfcTable IT_KNA1 = getDataSAP.GetTable("LTLTZTB001");
            DataSet1 dsUniversal = new DataSet1();

            DataTable dtKNA1 = dsUniversal.Tables["ZTB001"];

            dtKNA1 = CreateDataTable(dtKNA1, IT_KNA1);

            DGV1.DataSource = dtKNA1;
        }

        public static DataTable CreateDataTable(DataTable dt, IRfcTable rfcTable)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            IDestinationConfiguration destinationConfig;
            string destinationConfigName = "SE37";
            destinationConfig = null;
            bool destinationIsInitialised = false;
            if (!destinationIsInitialised)
            {
                destinationConfig = new rfc_Connector();
                destinationConfig.GetParameters(destinationConfigName);

                if (RfcDestinationManager.TryGetDestination(destinationConfigName) == null)
                {
                    RfcDestinationManager.RegisterDestinationConfiguration(destinationConfig);
                    destinationIsInitialised = true;
                }
                GlobalData.rfcDestination = RfcDestinationManager.GetDestination("SE37");
                GlobalData.rfcRepository = GlobalData.rfcDestination.Repository;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rfc_Connector cfg = null;
            cfg = new rfc_Connector();

            IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("ZFRFC001");
            //getDataSAP.SetValue("P_KUNNR", "ALL");

            IRfcTable IT_DATA = getDataSAP.GetTable("LTLTZTB001");

            IT_DATA.Clear();
            IT_DATA.Append();
            IT_DATA.SetValue("MANDT", "400");
            IT_DATA.SetValue("MATNR", matnr.Text);
            IT_DATA.SetValue("MAKTX", maktx.Text);

            //IT_DATA.Append();
            //IT_DATA.SetValue("MANDT", "400");
            //IT_DATA.SetValue("MATNR", "MATERIAL02");
            //IT_DATA.SetValue("MAKTX", "COBA MATERIAL TEST");

            try
            {
                getDataSAP.Invoke(GlobalData.rfcDestination);
                RfcSessionManager.EndContext(GlobalData.rfcDestination);

                var exObject = getDataSAP.GetObject("OUTPUT");
                IRfcStructure exStructure = getDataSAP.GetStructure("LS_ZTB001");
            }
            catch (Exception ex)
            {
                message = "SAP ZFDLKNA1 ";
                message += ex.Message;

                //RfcSessionManager.EndContext(GlobalData.rfcDestination);
                //Thread.Sleep(1000);
            }

            readdata();
        }
    }
}
