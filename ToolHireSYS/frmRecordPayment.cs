using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolHireSYS
{
    public partial class frmRecordPayment : Form
    {
        private frmMainMenu parent;

        public frmRecordPayment()
        {
            InitializeComponent();
        }

        public frmRecordPayment(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
        }

        private void txtRentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRentID_Click(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment SuccessFull");
            txtCreditDebit.ResetText();
            txtRentID.ResetText();
            txtPayment.ResetText();
            txtCustID.ResetText();
        }

        private void frmRecordPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
