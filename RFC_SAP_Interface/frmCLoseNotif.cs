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
    public partial class frmCLoseNotif : Form
    {
        public frmCLoseNotif()
        {
            InitializeComponent();
        }

        private void frmCLoseNotif_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            rfc_Connector cfg = null;
            cfg = new rfc_Connector();

            IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("ZPM_NOTIF_02_CLOSE");

            getDataSAP.SetValue("QMNUM", textBox1.Text);

            try
            {
                getDataSAP.Invoke(GlobalData.rfcDestination);
                RfcSessionManager.EndContext(GlobalData.rfcDestination);

                var exObject = getDataSAP.GetObject("MESSAGE");
                MessageBox.Show(exObject.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rfc_Connector cfg = null;
            cfg = new rfc_Connector();

            IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("ZPM_NOTIF_02_REWORK");

            getDataSAP.SetValue("QMNUM", textBox1.Text);

            try
            {
                getDataSAP.Invoke(GlobalData.rfcDestination);
                RfcSessionManager.EndContext(GlobalData.rfcDestination);

                var exObject = getDataSAP.GetObject("MESSAGE");
                MessageBox.Show(exObject.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
