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

namespace RFC_SAP_Interface
{
    public partial class frmCreateNotif : Form
    {
        public frmCreateNotif()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateStr = "";
            string timeStr = "";
            dateStr = dtDate.Text.Substring(6,4)+""+ dtDate.Text.Substring(3, 2) + "" + dtDate.Text.Substring(0, 2);
            timeStr = dtTime.Text.Substring(0, 2) + "" + dtTime.Text.Substring(3, 2) + "" + dtTime.Text.Substring(6, 2);

            rfc_Connector cfg = null;
            cfg = new rfc_Connector();

            IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("ZPM_NOTIF_01");

            IRfcStructure ls_ticketdata = getDataSAP.GetStructure("TICKED_DATA");
            IRfcStructure ls_result = getDataSAP.GetStructure("RESULT");

            ls_ticketdata.SetValue("EQFNR", txt01.Text);
            ls_ticketdata.SetValue("QMART", cb01.Text);
            ls_ticketdata.SetValue("QMTXT", txt02.Text);
            ls_ticketdata.SetValue("TPLNR", txt03.Text);
            ls_ticketdata.SetValue("EQUNR", txt04.Text);
            ls_ticketdata.SetValue("QMNAM", txt05.Text);
            ls_ticketdata.SetValue("QMDAT", dateStr);
            ls_ticketdata.SetValue("MZEIT", timeStr);

            ls_ticketdata.SetValue("PRIOK", cbPriok.Text);
            ls_ticketdata.SetValue("STRMN", dateStr);
            ls_ticketdata.SetValue("LTRMN", dateStr);
            ls_ticketdata.SetValue("STRUR", timeStr);
            ls_ticketdata.SetValue("LTRUR", timeStr);

            ls_ticketdata.SetValue("ZBEBER",  txt06.Text);
            ls_ticketdata.SetValue("ZBEBER2", txt07.Text);
            ls_ticketdata.SetValue("ZTPLNR2", txt08.Text);
            ls_ticketdata.SetValue("ZKOSTL",  txt09.Text);

            try
            {
                getDataSAP.Invoke(GlobalData.rfcDestination);
                RfcSessionManager.EndContext(GlobalData.rfcDestination);

                IRfcStructure exStructure = getDataSAP.GetStructure("RESULT");
                MessageBox.Show(exStructure.GetValue("MESSAGE") + " - " + exStructure.GetValue("DOCNUM"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCreateNotif_Load(object sender, EventArgs e)
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
    }
}
