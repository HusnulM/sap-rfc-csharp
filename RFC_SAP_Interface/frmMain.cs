using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFC_SAP_Interface
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCreateNotif createNotif = new frmCreateNotif();
            createNotif.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCLoseNotif closeNotif = new frmCLoseNotif();
            closeNotif.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmConfirmOrder confirmOrder = new frmConfirmOrder();
            confirmOrder.ShowDialog();
        }
    }
}
