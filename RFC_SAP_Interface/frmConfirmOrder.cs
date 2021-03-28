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
    public partial class frmConfirmOrder : Form
    {
        public frmConfirmOrder()
        {
            InitializeComponent();
        }

        private void frmConfirmOrder_Load(object sender, EventArgs e)
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

            IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("ZPM_ORDER_01_CONFIRM");

            IRfcTable IT_DATA = getDataSAP.GetTable("LT_ORDER_CONF");
            IT_DATA.Clear();
            IT_DATA.Append();
            IT_DATA.SetValue("AUFNR", aufnr.Text);
            IT_DATA.SetValue("VORNR", vornr.Text);
            if(ck1.Checked == true)
            {
                IT_DATA.SetValue("AUERU", "X");
            }

            try
            {
                getDataSAP.Invoke(GlobalData.rfcDestination);
                RfcSessionManager.EndContext(GlobalData.rfcDestination);

                //var exObject = getDataSAP.GetObject("MESSAGE");
                MessageBox.Show("Order Confirmed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
